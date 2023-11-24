using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userchoice;

            do {

                Console.WriteLine("choose operation: 1.helloworld 2.var and user i/p 3.arithmetic 4.control struct" +
                    "\n 5.loops 6.arrays 7.methods 8.exception handling");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("hello world");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("enter the name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("hello " + name);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("enter the first number: ");
                            int num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("enter the second number: ");
                            int num2 = int.Parse(Console.ReadLine());

                            Console.WriteLine($"adding {num1} and {num2}={num1 + num2}");

                            Console.WriteLine($"subtracting {num1} and {num2}={num1 - num2}");

                            Console.WriteLine($"multiplying {num1} and {num2}={num1 * num2}");

                            if (num2 != 0)
                            {
                                Console.WriteLine($"dividing {num1} and {num2}={num1 / (double)num2}");
                            }
                            else
                            {
                                Console.WriteLine("cannot divided by zero");
                            }

                            Console.WriteLine($"modulus: {num1 % num2}");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("enter an integer: ");
                            int usernum = int.Parse(Console.ReadLine());
                            if (usernum % 2 == 0)
                            {
                                Console.WriteLine("Given integer is a even number");
                            }
                            else
                            {
                                Console.WriteLine("Given integer is an odd number");
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Numbers from 1 to 10: ");
                            for (int i = 1; i <= 10; i++)
                            {
                                Console.WriteLine($"{i} ");
                            }
                            break;
                        }
                    case 6:
                        {
                            int[] array = { 12, 5, 8, 10, 20 };
                            int sum = 0;

                            foreach (var num in array)
                            {
                                sum += num;
                            }

                            double avg = sum / array.Length;
                            Console.WriteLine($"sum of an array is: {sum}");
                            Console.WriteLine($"avg of an array is: {avg}");
                            break;

                        }
                    case 7:
                        {
                            Console.Write("Enter an integer to calculate its factorial: ");
                            if (int.TryParse(Console.ReadLine(), out int factorialInput))
                            {
                                int result = CalculateFactorial(factorialInput);
                                Console.WriteLine($"Factorial: {result}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input for factorial calculation.");
                            }
                            break;
                        }
                    case 8:
                        {
                            int age;
                            bool validAge = false;

                            do
                            {
                                Console.Write("Enter your age: ");
                                if (int.TryParse(Console.ReadLine(), out age))
                                {
                                    validAge = true;
                                    if (age < 18)
                                    {
                                        Console.WriteLine("You are a minor.");
                                    }
                                    else if (age >= 18 && age <= 65)
                                    {
                                        Console.WriteLine("You are an adult.");
                                    }
                                    else 
                                    {
                                        Console.WriteLine("You are a senior."); 
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input for age. Please enter a valid integer.");
                                }
                            } while (!validAge);
                            break;
                        }
                        int CalculateFactorial(int n)
                        {
                            if (n == 0)
                                return 1;
                            else
                                return n * CalculateFactorial(n - 1);
                        }
                    default:
                        Console.WriteLine("entered a invalid operation!!!");
                        break;

                }
                Console.WriteLine("do you wanna continue? (yes/no): ");
                userchoice=Console.ReadLine().ToLower();

            }
            while(userchoice=="yes");

            Console.ReadKey();

            
        }
    }
}
