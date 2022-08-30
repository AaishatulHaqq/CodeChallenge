using System;

namespace CodeChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(GetWinnerOfCounterGame());
        }

        static string GetWinnerOfCounterGame()
        {
            string firstPerson = "Louise"; 
            string secondPerson = "Richard";
            //int counter = 0;
            Console.Write("Enter Number : ");
            int number = int.Parse(Console.ReadLine());

            if(number % 16 == 0) 
            {
                int result = number / 2;
                 return secondPerson;
            }

            if(number % 16 != 0)
            {
               int answer = number - (number % 8);
                 return firstPerson;
            }
            return firstPerson;
            return secondPerson;
        }

         static string GetBalancedSums()
        {
            Console.Write("Enter Length Of The Array : ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 0; i < length; i++)
            {
                Console.Write("Enter Elements[{0}] Of The Array : ", i);
                array[i] = int.Parse(Console.ReadLine);
                Console.WriteLine();
            }

            for(int i = 0; i < length; i++)
            {
                if(array[i] == array[array.Length / 2])
            }
        }
    }
}
