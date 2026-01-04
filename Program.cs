namespace CsharpProgram11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers do you want to enter?");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter the number");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                total += numbers[i];
            }
            float average = (float)total / n;
            Console.WriteLine("The average is: " + average);
        }
    }
}



