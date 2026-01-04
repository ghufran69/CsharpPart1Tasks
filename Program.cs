using System.Security.Cryptography;

namespace CsharpProgram11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Console.WriteLine("How many numbers do you want to enter?");
            //            int n = int.Parse(Console.ReadLine());
            //            int[] numbers = new int[n];
            //            for (int i = 0; i < n; i++)
            //            {
            //                Console.WriteLine("enter the number");
            //                numbers[i] = int.Parse(Console.ReadLine());
            //            }
            //            int total = 0;

            //            for (int i = 0; i < n; i++)
            //            {
            //                total += numbers[i];
            //            }
            //            float average = (float)total / n;
            //            Console.WriteLine("The average is: " + average);
            //        }
            //}
            //}


            //Task 2: Even or Odd
            //            while (true)
            //            {
            //                Console.WriteLine("Enter the numbers you want to check");
            //                float number = float.Parse(Console.ReadLine());
            //                if (number % 2 == 0)
            //                {
            //                    Console.WriteLine("the number is Even");

            //                }
            //                else
            //                {
            //                    Console.WriteLine("the number is Odd");

            //                }
            //                Console.WriteLine();

            //            }
            //        }
            //    }
            //}

            Console.WriteLine("How many numbers do you want to enter");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)

            {
                Console.WriteLine("enter the number");
                numbers[i] = int.Parse(Console.ReadLine());
            }
                int min = numbers[0];
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];

                }
            }
            Console.WriteLine("the smallest number is :" + min);

            }
        }
    }

