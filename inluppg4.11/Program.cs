using System;

namespace inluppg4_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening");
            string input = Console.ReadLine();

            // Array som sparar om indexen i fråga har varit checkad. Initierad till false
            bool[] checkedIndex = new bool[input.Length];

            bool somethingExists = false;
            for (int i = 0; i < input.Length; i++)
            {
                bool currentDupe = false;
                checkedIndex[i] = true;
                for (int j = i+1; j < input.Length; j++)
                {
                    if (input[i] == input[j] && checkedIndex[j] == false)
                    {
                        currentDupe = true;
                        somethingExists = true;
                        checkedIndex[j] = true;
                    }
                }
                if (currentDupe)
                {
                    Console.WriteLine(input[i] + " förekommer mer än en gång");
                }
            }
            if (somethingExists == false)
            {
                Console.WriteLine("Inga tecken förekommer mer än en gång");
            }

        }
    }
}