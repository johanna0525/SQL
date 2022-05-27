using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5

{
    public static class Practice12
    {
        public static void Main()
        {
            //1. reverse array
            PrintNumbers(Reverse(GenerateNumbers(10)));
            // 2. Fabonacci

            GetNthFibonacci(10);
            Console.WriteLine(GetNthFibonacci(10));
            //oop
            //7-1
            //using consturctor created
            Color Colorinstance = new Color(100, 80, 90,255);
            Console.WriteLine($"The value of red is {Colorinstance.Red}");
            Color colorExample = new Color();
            //defalut constructor
            colorExample.Alpha = 200;
            Console.WriteLine($"The value of Alpha is {colorExample.Alpha}");
          





        }
        //1. reverse array
        public static int[] GenerateNumbers(int n )
        {
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = i+1;
            }
            //Console.WriteLine(numbers); 
            return numbers;
        }

        public static int[] Reverse(int[] numbers)
        {
            int i = 0;
            int j = numbers.Length - 1;
            while(i < j)
            {
                var temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
                i++;
                j--;
            }
            Console.WriteLine(numbers);
            return numbers;
        }
        public static void PrintNumbers(int[] numbers)
        {
            Console.WriteLine(numbers);
            
        }
        // Fabonacci
        public static int GetNthFibonacci(int n)
        {
            int [] Fib = new int[n];
            Fib[0] = 1;
            Fib[1] = 1;
            for (int i = 2; i < n; i++)
            {
                Fib[i] = Fib[i-2] + Fib[i-1];
            }
            return Fib[n-1];
        }
    }
    //Designing and building Classes using object-oriented principles
    //1.
    public class Animal
    {
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Weight { get; set; }
        public string  Hobbies { get; set; }

       

        public virtual void makeSound()
        {
            Console.WriteLine("Animals can make different sound.");
        }
        
    }

    public class Dog: Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Woofwoof");
        }
    }

    public class Cat: Animal
    {
        public override void makeSound()
        {
            Console.WriteLine(" Meowmeow");
        }
        //constructor 
        public Cat(string color, int weight, string hobbies)
        {
            Color = color;
            Weight = weight;
            Hobbies = hobbies;

        }
        public Cat(string color, int weight)
        {
            Color=color;
            Weight = weight;
        }
    }

    //2-6
    public class Person
    {
        public string Name { get; set; }

        private int id;
        public int Id
        {
            get { return id; }
            private set { id = value; }
        }
        public decimal Salary { get; set; }
        public string[] Addresses { get; set; }
        public virtual void CalculateAge()
        {
            Console.WriteLine("Calculate the age with proper method");
        }
        public virtual void CalculateSalary()
        {
            Console.WriteLine("CalculateSalary according to the proper method");
        }
       
    }

    public class Student : Person
    {
        public string[] CoursesTaken { get; set; }
        public Dictionary<string, string > Courses { get; set; }

        public void CalculateGPA()
        {
            Console.WriteLine("Grade can be calculated according GPA");
        }
    }

    public class Instructor : Person
    {
        public string DepartmentBelongingTo { get; set; }
        public bool HeadOrNot { get; set; }
        public DateTime JoinDate { get; set; }

        public override void CalculateSalary()
        {
            Console.WriteLine($"The salary will include bonus based on experience");
        }
        public void YearsOfExperience()
        {
            Console.WriteLine($"Work experience is the differenc between now and JoinDate{DateTime.Now - JoinDate } ");
        }
        
    }
    public class Course
    {
        public List<string> StudentsList { get; set; }
    }
    public class Department
    {
        public string Head { get; set; }
        public decimal Budget { get; set; }
        public List<string> Courses { get; set; }

    }

    



    //7
    //color class
    public class Color
    {
        public byte Red{ get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; }
        public double grayscaleValue(byte red, byte green, byte blue)
        {
            return (red + green + blue)/3;
        }

        //Constructor
        public Color()
        {

        }
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        /*public Color(byte red, byte green, byte blue, byte alpha = 255)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }*/


    }

    //ball class
    public class Ball:Color
    {
        public int Size { get; set; }
        public int TimesBeingThrown { get; set; }
        public int ThrowCount { get; set; }


        //constructor
        //default
        public Ball() { }
        //new constructor
        public Ball(int size, int timesbeingthrown)
        {
            Size = size;
            TimesBeingThrown = timesbeingthrown;

        }
        //methods
        public void pop()
        {
            Size = 0;

        }

        public int throwMethod()
        {
            if( Size != 0)
            {
                ThrowCount += 1;

            }
            return ThrowCount;
           
        }

        public int totalThrownNumbers()
        {
            return throwMethod();
        }
      

       





    }
















}
