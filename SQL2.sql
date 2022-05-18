USE AdventureWorks2019
GO
----1.	  
SELECT c.Name AS Country, s.Name AS Province 
	FROM Person.CountryRegion c 
	JOIN
	Person.StateProvince s
	ON c.CountryRegionCode = s.CountryRegionCode;

---2.
SELECT c.Name AS Country, s.Name AS Province 
	FROM Person.CountryRegion c 
	JOIN
	Person.StateProvince s
	ON c.CountryRegionCode = s.CountryRegionCode
	WHERE c.Name NOT IN ('Germany', 'Canada');	

USE Northwind
GO
---3.	
    SELECT DISTINCT p.ProductID, p.ProductName
	FROM Orders o
	JOIN
	[Order Details] od
	ON o.OrderID =  od.OrderID
	JOIN 
	Products p
	ON od.ProductID = p.ProductID
	WHERE DATEDIFF(year, o.OrderDate, GETDATE())< 25;

	SELECT DISTINCT p.ProductID,ProductName
    FROM Products p JOIN [Order Details] od ON P.ProductID = od.ProductID JOIN Orders o ON od.OrderID = o.OrderID
    WHERE o.OrderDate > DATEADD(year, -25, GETDATE())
	ORDER BY ProductID
--4
SELECT TOP 5 o.ShipPostalCode AS ZipCode,SUM(od.UnitPrice*od.Quantity) AS TotalSales
FROM Products p JOIN [Order Details] od ON P.ProductID = od.ProductID JOIN Orders o ON od.OrderID = o.OrderID
WHERE o.OrderDate > DATEADD(year, -25, GETDATE())
GROUP BY  o.ShipPostalCode
ORDER BY SUM(od.UnitPrice*od.Quantity) DESC

--5
SELECT City, COUNT(CustomerID) as NumberOfCustomer
FROM dbo.Customers
GROUP BY City

--6
SELECT City, COUNT(CustomerID) as NumberOfCustomer
FROM dbo.Customers
GROUP BY City
HAVING COUNT(CustomerID) > 2
--7
SELECT c.CompanyName, COUNT(DISTINCT od.ProductID) 
FROM dbo.Customers c JOIN  Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CompanyName

--8
SELECT c.CompanyName, COUNT(DISTINCT od.ProductID) 
FROM dbo.Customers c JOIN  Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CompanyName
HAVING COUNT(DISTINCT od.ProductID) > 100

--9
SELECT s.CompanyName [Supplier Company Name], sh.CompanyName [Shipping Company Name]
FROM Suppliers s JOIN Products p ON s.SupplierID = p.SupplierID
    JOIN [Order Details] od ON p.ProductID = od.ProductID
    JOIN Orders o ON od.OrderID = o.OrderID
    JOIN Shippers sh ON o.ShipVia = sh.ShipperID
ORDER BY [Supplier Company Name]

--10
SELECT DISTINCT p.ProductName, CONVERT(VARCHAR, o.OrderDate, 23) AS OrderDate
FROM Products p JOIN [Order Details] od ON P.ProductID = od.ProductID JOIN Orders o ON od.OrderID = o.OrderID
ORDER BY OrderDATE DESC

--11

SELECT e1.EmployeeID,  e2.EmployeeID
FROM dbo.Employees e1 JOIN dbo.Employees e2 ON e1.Title = e2.Title
WHERE e1.EmployeeID != e2.EmployeeID
    AND e1.EmployeeID < e2.EmployeeID

--12
SELECT e.EmployeeID, e.FirstName, e.LastName
FROM dbo.Employees  e JOIN (SELECT ReportsTo 
                            FROM dbo.Employees
                            GROUP BY ReportsTo
                            HAVING COUNT(ReportsTo) > 2) AS t
    ON e.EmployeeID = t.ReportsTo

--13
SELECT City, CompanyName AS Name, ContactName AS [Contact Name], 'Customer' AS Type
FROM dbo.Customers

UNION

SELECT City, CompanyName AS Name, ContactName AS [Contact Name], 'Supplier' AS Type
FROM Suppliers
--14
SELECT DISTINCT e.City
FROM Employees e JOIN Customers c ON e.City = c.City

--15
--1)Use sub-query
SELECT City
FROM Customers
WHERE City NOT IN (SELECT DISTINCT City FROM Employees)

--2)Not use sub_query
SELECT c.City
FROM Customers c LEFT JOIN Employees e ON c.City = e.City
WHERE e.City IS NULL

--16
SELECT p.ProductID,p.ProductName, ISNULL(SUM(od.Quantity), 0) TotalQuantities
FROM Products p LEFT JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductID,p.ProductName
--17
--1)Use UNION
SELECT City 
FROM Customers
EXCEPT
(
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) = 1
UNION
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) = 2
)

--2)Use Sub-query and no UNION
SELECT DISTINCT City
FROM Customers
WHERE City IN(SELECT City 
              FROM Customers 
			  GROUP BY City
			  HAVING COUNT(CustomerID) >2)

--18
SELECT City
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City
HAVING COUNT(DISTINCT od.ProductID) >= 2

--19
WITH cte_Top5_Avg 
AS
(
SELECT p.ProductID, AVG(p.UnitPrice) over() AvgPrice
FROM Products p JOIN (SELECT TOP 5 ProductID, SUM(Quantity) TotalSales
                      FROM [Order Details]
                      GROUP BY ProductID
                      ORDER BY TotalSales DESC) t
    ON p.ProductID = t.ProductID
),

cte2
AS
(
SELECT cte.ProductID, cte.AvgPrice, c.City, SUM(od.Quantity) OVER(PARTITION BY c.City) SumSales
FROM cte_Top5_Avg cte JOIN [Order Details] od ON cte.ProductID = od.ProductID JOIN Orders o ON od.OrderID = o.OrderID JOIN Customers c ON o.CustomerID = c.CustomerID
)

SELECT ProductID, AvgPrice, City
FROM (SELECT ProductID, AvgPrice, City,DENSE_RANK() OVER(ORDER BY SumSales DESC ) rnk
      FROM cte2) t2
WHERE rnk <= 5

--20

WITH cte1
AS
(SELECT c.City, COUNT(o.OrderID) TotalOrders
 FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
 GROUP BY c.City),

cte2
AS
(
SELECT City
FROM cte1
WHERE TotalOrders =(SELECT MAX(TotalOrders) FROM cte1
),

cte3 
AS
(SELECT c.City, SUM(od.Quantity) TotalQuantity
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City),

cte4
AS
(
SELECT City 
FROM cte3
WHERE TotalQuantity = (SELECT MAX(TotalQuantity) FROM cte3)

SELECT City 
FROM cte2
WHERE City IN (SELECT City FROM cte4)

--21
--1) Using "select distinct *"
--2)Using Windonw function: with cte as (select *,row_number() over(partition by * order by "any column") rk from table )
---select * from cte where rk=1
--3)Using group by 