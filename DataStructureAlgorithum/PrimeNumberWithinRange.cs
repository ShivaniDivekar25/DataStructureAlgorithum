using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithum
{
    public class PrimeNumberWithinRange
    {
        public static void FindPrimeNumbers()
        {
            Console.WriteLine("Please enter input range");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input <= 1)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                for (int num = 2; num <= input; num++)
                {
                    int flag = 0;
                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                    {
                        Console.Write(num + " ");
                    }
                }
            }
        }
    }
}
