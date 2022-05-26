using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Questions
    {
        public static void Main()
        {
            //Question0();
            //Question1();

            // Question2(1);
            // Question2(5);

            //Question2_1();
            //Question2_2();
            //Question2_3();
            //Question2_4();
            //Question2_5();
            //Question2_6();
         
        }
        //Introduction to C# and Data Types 0-9

        public static string Question0()
        {
            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine($"Your name is: {name}");
            return name;

            /*Console.WriteLine("How old are you");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your name is:{age}");
            if (age >= 18)
            {
                Console.WriteLine("You can vote");
            }
            else
            {
                Console.WriteLine("Sorry, you can't vote");
            }
            return age;*/

        }

        public static void Question1()
        {
            //number of bytes in memory
            Console.WriteLine("The size of sbyte is:" + sizeof(sbyte));
            Console.WriteLine("The size of byte is:" + sizeof(byte));
            Console.WriteLine("The size of short is:" + sizeof(short));
            Console.WriteLine("The size of ushort is:" + sizeof(ushort));
            Console.WriteLine("The size of int is:" + sizeof(int));
            Console.WriteLine("The size of unit is:" + sizeof(uint));
            Console.WriteLine("The size of long is:" + sizeof(long));
            Console.WriteLine("The size of ulong is:" + sizeof(ulong));
            Console.WriteLine("The size of float is:" + sizeof(float));
            Console.WriteLine("The size of double is:" + sizeof(double));
            Console.WriteLine("The size of decimal is:" + sizeof(decimal));
            // max value

            Console.WriteLine($"The max value of sbyte is {sbyte.MaxValue}");
            Console.WriteLine($"The max value of byte is {byte.MaxValue}");
            Console.WriteLine($"The max value of short is{short.MaxValue}");
            Console.WriteLine($"The max value of ushort is {ushort.MaxValue}");
            Console.WriteLine($"The max value of int is {int.MaxValue}");
            Console.WriteLine($"The max value of unit is {ushort.MaxValue}");
            Console.WriteLine($"The max value of ulong is {ulong.MaxValue}");
            Console.WriteLine($"The max value of long is {long.MaxValue}");
            Console.WriteLine($"The max value of float is {float.MaxValue}");
            Console.WriteLine($"The max value of double is{double.MaxValue}");
            Console.WriteLine($"The max value of decimal is{decimal.MaxValue}");

            //min value
            Console.WriteLine("The min value of sbyte is{0}", sbyte.MinValue);
            Console.WriteLine("The min value of byte is{0}", byte.MinValue);
            Console.WriteLine("The min value of short is{0}", short.MinValue);
            Console.WriteLine("The min value of ushort is{0}", ushort.MinValue);
            Console.WriteLine("The min value of int is{0}", int.MinValue);
            Console.WriteLine("The min value of unit is{0}", uint.MinValue);
            Console.WriteLine("The min value of ulong is {0}", ulong.MinValue);
            Console.WriteLine("The min value of long is{0}", long.MinValue);
            Console.WriteLine("The min value of float is{0}", float.MinValue);
            Console.WriteLine("The min value of double is{0}", double.MinValue);
            Console.WriteLine("The min value of decimal is{0}", decimal.MinValue);
        }

        public static void Question2(byte centeries)
        {
            int years = 100 * centeries;
            int days = 365 * years;
            int hours = 24 * days;
            int minutes = 60 * hours;
            long seconds = 60 * minutes;
            long milliseconds = 1000 * seconds;
            long microseconds = 1000 * milliseconds;
            ulong nanoseconds = (ulong)(1000 * microseconds);
            Console.WriteLine($"{centeries} centeries = {years} years = {days} days ={hours}hours =" +
                $"{seconds}seconds ={milliseconds} milliseconds = {microseconds} microseconds =  {nanoseconds} nanoseconds");
        }

        public static void Question2_1()
        {   // 1) fizzbuzz
            int n = 100;
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("fizzbuzz" + " ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("fizz" + " ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("buzz" + " ");
                }
                else
                    Console.Write(i + " ");
            }

            // 2)
            /* int max = 500;
             for (byte i = 0; i < max; i++)
             {
                 Console.WriteLine(i)
             }*/
            // Because the max value of byte is less than 500,so there will be overflows.


            // guess number
            int correctNUmber = new Random().Next(3) + 1;
            Console.WriteLine(correctNUmber);
            Console.WriteLine("Enter the number you guess: ");
            int guessNumber = int.Parse(Console.ReadLine());
            if (guessNumber > 3 || guessNumber < 1)
            {
                Console.WriteLine("The number you guess is out of range.");
            }
            else if (guessNumber > correctNUmber)
            {
                Console.WriteLine("The number is too high");
            }
            else if (correctNUmber > guessNumber)
            {
                Console.WriteLine("The number is too low");
            }
            else
            {
                Console.WriteLine("Congradulations! You get the correct answer!");
            }

        }

        public static void Question2_2()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.Write(" \n");
            }
        }

        public static void Question2_3()
        {
            int correctNUmber = new Random().Next(3) + 1;
            Console.WriteLine(correctNUmber);
            Console.WriteLine("Enter the number you guess: ");
            int guessNumber = int.Parse(Console.ReadLine());
            if (guessNumber > 3 || guessNumber < 1)
            {
                Console.WriteLine("The number you guess is out of range.");
            }
            else if (guessNumber > correctNUmber)
            {
                Console.WriteLine("The number is too high");
            }
            else if (correctNUmber > guessNumber)
            {
                Console.WriteLine("The number is too low");
            }
            else
            {
                Console.WriteLine("Congradulations! You get the correct answer!");
            }

        }

        public static void Question2_4()
        {
            int year = 1999;
            int month = 2;
            int day = 6;
            //int hour = 9;
            //int minute = 10;
            //int second = 11;
            // DateTime birthdate = new DateTime(2022, 2, 6);
            int current_year = DateTime.Now.Year;
            int current_month = DateTime.Now.Month;
            int current_day = DateTime.Now.Day;

            int days = (current_year - year) * 365 + (current_month - month) * 30 + (current_day - day);
            Console.WriteLine($"The total days is {days} days");
        }

        public static void Question2_5()
        {
            int year = 2022;
            int month = 2;
            int day = 6;
            int hour = 9;
            int minute = 10;
            int second = 11;
            DateTime time = new DateTime(2022, 2, 6, 9, 10, 11);
            Console.WriteLine(time.ToString());
            Console.WriteLine(time.Hour);
            if (time.Hour >= 0 && time.Hour < 12)
            {
                Console.WriteLine("Good moring");
            }
            if (time.Hour >= 12 && time.Hour < 18)
            {
                Console.WriteLine("Good afternoon");

            }
            if (time.Hour >= 18 && time.Hour < 21)
            {
                Console.WriteLine("Good evening");

            }
            else
            {
                Console.WriteLine("Good night");
            }
        }
        public static void Question2_6()
        {
            int n = 24;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 25; j = j + i + 1)
                {
                    Console.Write(j + ",");
                }
                Console.WriteLine();
            }
        }

        // Arrays and Strings
        //1.
        public void CopyAnArray(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
                Console.WriteLine($"the {i}th element of arr is {arr[i]}");
                Console.WriteLine($"the {i}th element of newArr is {newArr[i]}");
            }
        }
        //2.

       public void ManageElements()
        {
            List<string> list = new List<string>();
            Console.WriteLine("Enter command(+item, - item or --to clear):");
            string operation = Console.ReadLine();
            while (operation != null)
            {

                switch (operation)
                {

                    case "+":
                        Console.Write("Please enter the element:");
                        list.Add(Console.ReadLine());
                        Console.WriteLine($"The current list is: ");
                        foreach (var item in list)
                        {

                            Console.Write(item + "\t");
                        }

                        Console.WriteLine();

                        break;
                    case "-":

                        list.RemoveAt(list.Count - 1);
                        Console.WriteLine($"The current list is:{list }");
                        Console.WriteLine($"The current list is: "); 
                        foreach (var item in list)

                        {
                            Console.Write(item + "\t");

                        }
                        Console.WriteLine(); 
                        break;

                    case "--":
                        list.Clear();

                        Console.WriteLine("You have removed all the elements");

                        break;
                    default:

                        Console.WriteLine("Invalid operation");

                        break;
                }

                Console.WriteLine("Insert another input to Continue: ");

                operation = Console.ReadLine();
            }

        }

        //3.
        public int[] FindPrimesInRange(int startNum, int endNum)
        {
            if (startNum < 0 || endNum < 0) || startNum > endNum)
                    {
                return null;    
            }
            List<int> primes = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                for (int j =2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                
                }
                primes.Add(i);
            }
            return primes.ToArray();

        }

        //4.
        public int[] SumAfterRotation(int[] arr, int k)
        {

            int times = k / arr.Length;
            int move = k % arr.Length;
            int sum = 0;
            int[] res = new int[arr.Length]; foreach (var item in arr)

            {
                sum = sum + item;

            }
            sum = sum * times;
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = 1; j <= move; j++)
                {

                    if (i - j >= 0)
                    {

                        res[i] = res[i] + arr[i - j];
                    }

                    else
                    {

                        res[i] = res[i] + arr[i - j + arr.Length];
                    }

                }

                res[i] = sum + res[i];
            }

            return res;
        }

        //5.
        public int[] LongestSequence(int[] arr)
        {

            int num = arr[0];
            int maxCount = 1; 
            int count = 1; 
            for (int i = 1; i < arr.Length; i++)
            {

                if (arr[i] == arr[i - 1])
                {

                    count++; 
                    if (count > maxCount)
                    {
                        maxCount = count;

                        num = arr[i];
                    }

                 } 
                else
                { 

                    count = 1; } 

                }
                int[] res = new int[maxCount];
                Array.Fill(res, num);
                return res; 

        }
        //6.
        public void MostFrequentNumber(int[] arr)
        {

            Dictionary<int, int> freq = new Dictionary<int, int>();
            Dictionary<int, int> firstOccurrence = new Dictionary<int, int>(); 
            int leftmost = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {

                if (!freq.ContainsKey(arr[i]))
                {

                    freq.Add(arr[i], 1); 
                    firstOccurrence.Add(arr[i], i);

                }
                else
                {

                    freq[arr[i]]++;
                }

            }
            int mostFreq = freq.Values.Max();
            int num = -1;
            foreach (var key in freq.Keys)
            {

                if (freq[key] == mostFreq && firstOccurrence[key] < leftmost)
                {

                    leftmost = firstOccurrence[key];

                    num = arr[leftmost];
                }

            }

            Console.WriteLine($"The number {num} is the most frequent (occurs {mostFreq} times)");
        }
        //strings
        //1.
        public string ReverseStringOne(string s)
        {

            if (s == null)
            {

                return string.Empty;
            }

            char[] chars = s.ToCharArray();
            for (int i = 0, j = chars.Length - 1; i < j; i++, j--)
            {

                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;

            }
            string res = new string(chars); 
            return res;

        }

        //2.
        public string ReverseWords(string s)
        {

            if (s == null)
            {

                return string.Empty;
            }

            char[] separators = new char[] { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '/', '\\', '!', '?', ' ' };
            char[] chars = s.ToCharArray();
            int n = chars.Length;



            bool isWord = true;
            StringBuilder sb = new StringBuilder(); 
            List<string> wordsList = new List<string>(); 
            List<string> separatorList = new List<string>(); 
            foreach (var c in chars)
            {

                if (isWord)
                {

                    if (separators.Contains(c))
                    {

                        wordsList.Add(sb.ToString());
                        sb.Clear();
                        isWord = !isWord;

                    }
                }

                else
                {

                    if (!separators.Contains(c))
                    {

                        separatorList.Add(sb.ToString());
                        sb.Clear();
                        isWord = !isWord;

                    }
                }

                sb.Append(c);
            }

            separatorList.Add(sb.ToString());
            sb.Clear();
            int m = wordsList.Count();
            for (int i = 0; i < m; i++)

            {
                sb.Append(wordsList[m - 1 - i]);
                sb.Append(separatorList[i]);

            }

            return sb.ToString();
        }

        //3.
        public string[] FindPalindrome(string s)
        {

            if (s == null)
            {

                return null;
            }

            HashSet<string> wordsSet = new HashSet<string>();
            bool isWord = true;
            StringBuilder sb = new StringBuilder();
            char[] chars = s.ToCharArray();

            foreach (var c in chars)
            {

                if (isWord)
                {

                    if (!char.IsLetter(c))
                    {

                        wordsSet.Add(sb.ToString());
                        sb.Clear();
                        isWord = !isWord;

                    }
                    else
                    {

                        sb.Append(c);
                    }

                }
                else
                {

                    if (char.IsLetter(c))
                    {

                        sb.Append(c);

                        isWord = !isWord;
                    }

                }
            }

            foreach (var word in wordsSet)
            {

                if (!IsPalindrome(word))
                {

                    wordsSet.Remove(word);
                }

            }

            return wordsSet.ToArray();
        }

        private bool IsPalindrome(string s)
        {

            if (s.Length <= 1)
            {

                return true;
            }

            int i = 0, j = s.Length - 1;
            while (i < j)
            {

                if (s[i] != s[j])
                {

                    return false;
                }
                else

                {
                    i++;

                    j--;
                }

            }

            return true;
        }
        //4.
        public void ParseUrl(string url)
        {

            char[] seperator = new char[] { ':', '/', '/' };
            int i = url.IndexOfAny(seperator);
            string protocal, secondHalf;
            if (i != -1)

            {
                protocal = url.Substring(0, i); 
                secondHalf = url.Substring(i + 3);

            }
            else
            {

                protocal = " ";

                secondHalf = url;
            }

            string[] temp = secondHalf.Split('/'); string server = temp[0];
            string resource;
            if (temp.Length > 1)

            {
                resource = temp[1];

            }
            else
            {

                resource = " ";
            }

            Console.WriteLine($"[protocal] = {protocal}"); 
            Console.WriteLine($"[server] = {server}"); 
            Console.WriteLine($"[resource] = {resource}");

        }



































    }













}
