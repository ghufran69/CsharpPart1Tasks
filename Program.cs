using System.ComponentModel.Design;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            //Task 3
            //        Console.WriteLine("How many numbers do you want to enter");
            //        int n = int.Parse(Console.ReadLine());
            //        int[] numbers = new int[n];
            //        for (int i = 0; i < n; i++)

            //        {
            //            Console.WriteLine("enter the number");
            //            numbers[i] = int.Parse(Console.ReadLine());
            //        }
            //            int min = numbers[0];
            //        for (int i = 0; i < n; i++)
            //        {
            //            if (numbers[i] < min)
            //            {
            //                min = numbers[i];

            //            }
            //        }
            //        Console.WriteLine("the smallest number is :" + min);

            //        }
            //    }
            //}
            //Task4 
            //    Console.WriteLine("How many numbers do you want to enter");
            //    int n = int.Parse(Console.ReadLine());
            //    int[] numbers = new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.WriteLine("Enter the number");
            //        numbers[i] = int.Parse(Console.ReadLine());
            //    }
            //    int positivecount = 0;
            //    int negativecount = 0;

            //        for (int i = 0; i < n; i++)
            //        {
            //        if (numbers[i] > 0)

            //        {
            //            positivecount++;
            //        }
            //        else if (numbers[i] < 0)
            //        {
            //            negativecount++;
            //        }




            //        }
            //    Console.WriteLine("positive number count:" + positivecount);
            //    Console.WriteLine("negative number count:"+ negativecount);
            //    }

            //    }
            //}

            //Task 5
            //            Console.WriteLine("How many numbers do you want to enter");
            //            int n = int.Parse(Console.ReadLine());

            //            int[] numbers = new int[n];

            //            for (int i = 0; i < n; i++)

            //            {
            //                Console.WriteLine("enter number");
            //                numbers[i] = int.Parse(Console.ReadLine());
            //            }

            //            int[] uniquenumbers = new int[n];
            //            int uniqueCount = 0;
            //            for (int i = 0; i < n; i++)
            //            {
            //                bool isDuplicate = false;

            //                for (int j = 0; j < uniqueCount; j++)
            //                {
            //                    if (numbers[i] == uniquenumbers[j])
            //                    {
            //                        isDuplicate = true;
            //                        break;
            //                    }
            //                }

            //                if (isDuplicate == false)
            //                {
            //                    uniquenumbers[uniqueCount] = numbers[i];
            //                    uniqueCount++;
            //                }
            //            }
            //            Console.Write("[ ");
            //            for (int i = 0; i < uniqueCount; i++)
            //            {
            //                Console.Write(uniquenumbers[i] + " ");
            //            }
            //            Console.Write("]");

            //        }

            //    }
            //}

            //Task6
            Console.WriteLine("Enter how many numbers do you want to enter");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("primenumber:");

            for (int i= 2;i<n;i++)
            {

                bool isprime = true;
                for (int j = 2; j < i; j++)
                {

                    if (i % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                {
                    Console.WriteLine(i + " "); 
                }
                
                    
              

                   

                    

                }

            }
        }
    }
