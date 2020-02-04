using System;

namespace ConditionalStatementKyleBigelow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What total score (out of 100) do you plan to make in ISM4300? (Please use 2 digits with no percentage sign)");
            int response = int.Parse(Console.ReadLine());

            if (response >= 97)
            {
                Console.WriteLine("Your grade would be an A+");
            }
            else if (response >= 92 && response <= 96)
            {
                Console.WriteLine("Your grade would be an A");
            }
            else if (response >= 90 && response <= 91)
            {
                Console.WriteLine("Your grade would be an A-");
            }
            else if (response >= 88 && response <= 89)
            {
                Console.WriteLine("Your grade would be a B+");
            }
            else if (response >= 82 && response <= 87)
            {
                Console.WriteLine("Your grade would be a B");
            }
            else if (response >= 80 && response <= 81)
            {
                Console.WriteLine("Your grade would be a B-");
            }
            else if (response >= 78 && response <= 79)
            {
                Console.WriteLine("Your grade would be a C+");
            }
            else if (response >= 72 && response <= 77)
            {
                Console.WriteLine("Your grade would be a C");
            }
            else if (response >= 70 && response <= 71)
            {
                Console.WriteLine("Your grade would be a C-");
            }
            else if (response >= 68 && response <= 69)
            {
                Console.WriteLine("Your grade would be a D+");
            }
            else if (response >= 62 && response <= 67)
            {
                Console.WriteLine("Your grade would be a D");
            }
            else if (response >= 60 && response <= 61)
            {
                Console.WriteLine("Your grade would be a D-");
            }
            else if (response <= 60)
            {
                Console.WriteLine("Your grade would be an F");
            }

        }
    }
}