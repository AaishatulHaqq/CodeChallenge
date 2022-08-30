using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge1
{
    public class WorkSpace
    {
        static string GetWinnerOfCounterGame()
        {
            string firstPerson = "Louise"; 
            string secondPerson = "Richard";
            //int counter = 0;
            Console.Write("Enter Number : ");
            int number = int.Parse(Console.ReadLine());

            if(number % 16 == 0) 
            {
                number / 2;
                return secondPerson;
            }

            if(number % 16 != 0)
            {
                number - (number % 8);
                 return firstPerson;
            }

        }

        // static string GetBalancedSums()
        // {
        //     Console.Write("Enter Length Of The Array : ");
        //     int length = int.Parse(Console.ReadLine());
        //     Console.WriteLine();

        //     for(int i = 0; i < length; i++)
        //     {
        //         Console.Write("Enter Elements[{0}] Of The Array : ", i);
        //         array[i] = int.Parse(Console.ReadLine);
        //         Console.WriteLine();

                

        //     }
        // }


    }
}