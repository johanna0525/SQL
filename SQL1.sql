USE AdventureWorks2019
GO

--1
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product

--2
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE ListPrice != 0

--3
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NULL

--4
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NOT NULL

--5
SELECT Name + ' ' + Color [Name Color]
FROM Production.Product
WHERE Color IS NOT NULL

--6
SELECT TOP 6 Name, Color
FROM Production.Product
WHERE Color IN ('Black', 'Silver')

--7
SELECT ProductID, Name
FROM Production.Product
WHERE ProductID BETWEEN 400 AND 500

--8
SELECT ProductID, Name, Color
FROM Production.Product
WHERE Color IN ('Black', 'Blue')

--9
SELECT *
FROM Production.Product
WHERE Name LIKE 'S%'

--10
SELECT Name, ListPrice
FROM Production.Product
WHERE Name LIKE 'S%' OR Name LIKE 'A%'
ORDER BY Name

--11
SELECT *
FROM Production.Product
WHERE Name LIKE 'SPO[^K]%'

--12
SELECT DISTINCT ProductSubcategoryID, Color
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL AND Color IS NOT NULL

