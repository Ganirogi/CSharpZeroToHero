﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Problem1");
        Problem1();
        Console.WriteLine("Problem2");
        Problem2();
        Console.WriteLine("Problem3");
        Problem3(47);
        Console.WriteLine("Problem4");
        Problem4();
        Console.WriteLine("Problem5");
        Problem5();
        Console.WriteLine("Challenge1");
        Challenge1(10011010);
        Console.WriteLine("Challenge2");
        Challenge2(154);


        //1. Write a program that reads a number from the keyboard. Check whether that number is divisible by 7 and 11 or not.
        static void Problem1()
        {
            Console.WriteLine("Input an integer");
            int n = int.Parse(Console.ReadLine());
            if (n % 7 == 0 && n % 11 == 0)
                Console.WriteLine(n + " is divisible to 7 and 11 ");
            else
                Console.WriteLine(n + " is not divisible by 7 and 11");
        }

        //2. Check whether a given year is leap year or not.
        static void Problem2()
        {
            Console.WriteLine("Input an year");
            int n = int.Parse(Console.ReadLine());
            if (n % 400 == 0 || n % 100 != 0 && n % 4 == 0)
                Console.WriteLine(n + " is a leap year");
            else
                Console.WriteLine(n + " is not a leap year");
        }

        //3. By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13. What is the 47th prime number?
        static void Problem3(int n)
        {
            //Console.WriteLine("Input nth prime number you want to find");
            //int n = int.Parse(Console.ReadLine());
            int MAX_SIZE = n * 20;
            int count = 0;

            bool[] IsPrime = new bool[MAX_SIZE];

            for (int i = 0; i < MAX_SIZE; i++)
            {
                IsPrime[i] = true;
            }

            for (int p = 2; p * p < MAX_SIZE; p++)
            {
                if (IsPrime[p] == true)
                {
                    for (int i = p * p; i < MAX_SIZE; i += p)
                        IsPrime[i] = false;
                }
            }

            for (int p = 2; p < MAX_SIZE; p++)
                if (IsPrime[p] == true)
                {
                    count++;
                    if (count == n)
                    {
                        Console.WriteLine("The " + n + "th prime number is " + p);
                        break;
                    }

                }
        }

        /*4.  Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
        1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
        By considering the terms in the Fibonacci sequence whose values do not exceed 1000, find the sum of the even-valued terms.*/
        static void Problem4()
        {
            int[] fib = new int[16];
            int n = 1;
            int i = 0;
            int j = 0;
            int max = 0;
            int sum = 0;

            while (max < 980)
            {
                fib[j] = i + n;
                max = fib[j];
                i = n;
                n = max;
                if (fib[j] % 2 == 0)
                {
                    sum += fib[j];
                }
                j++;
            }
            Console.WriteLine("Sum of even numbers of Fibonacci sequece lower than 1000 is " + sum);
        }

        //5. Find the sum of digits of a number read from the keyboard.
        static void Problem5()
        {
            Console.WriteLine("Input a integer to find the sum of his digits");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Sum of " + n + "'s digits is ");
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine(sum);
        }

        //Challenge 1.Convert Binary 10011010 to Decimal number system.
        static void Challenge1(long n)
        {
            //Console.WriteLine("Input a binary number");
            //int n = int.Parse(Console.ReadLine());
            Console.Write("Decimal number of Binary number " + n + " is ");
            long sum = 0;
            int m = n.ToString().Length;

            for (int i = 0; i < m; i++)
            {
                sum += (int)Math.Pow(2, i) * (n % 10);
                n /= 10;
            }
            Console.WriteLine(sum);
        }

        // Challenge 2.Find an optimal solution to the code that converts a decimal to binary.

        static void Challenge2(int number)
        {
            if (number < 0)
            {
                Console.WriteLine("Please give a positive number.");
                return;
            }

            Console.Write("Binary number of Decimal number " + number + " is ");

            //int binary = 0;
            //int temp = 1;

            string result = "";

            while (number > 0)
            {
                int r = number % 2;

                //temp = temp * 10 + r;

                result = string.Concat(r.ToString(), result);

                number /= 2;

            }
            /*while (temp > 0)
            {
                binary = binary * 10 + temp % 10;

                temp = temp / 10;
            }
            binary = binary / 10;
            */
            Console.WriteLine(result);
        }
    }
}