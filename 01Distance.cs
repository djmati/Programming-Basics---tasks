using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            bool istesting = true;
            while (istesting)
            {
                Console.Write("Enter even number: ");
                string number = Console.ReadLine();

                try
                {
                    int numeral = Convert.ToInt32(number);
                    if (numeral % 2 == 0 && numeral != 0)
                    {
                        Console.WriteLine("Even number entered: {0}", numeral);
                        istesting = false;
                    }

                    else
                        Console.WriteLine("The number is not even.");
                }
                catch
                {
                    Console.WriteLine("Невалиден номер!");
                }
            }
        }
    }
}