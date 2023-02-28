using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithum
{
    public class BinarySearch
    {
        public static void result(string[] arr2, object k)
        {
            int res = Array.BinarySearch(arr2, k);
            if (res < 0)
            {
                Console.WriteLine("\nThe element to search for {0} is not found.", k);
            }
            else
            {
                Console.WriteLine("The element to search for {0} is at index {1}", k, res); ;
            }
        }
        public static void display(string[] arr1)
        {
            foreach (string i in arr1)
                Console.WriteLine(i + " ");
        }
    }
}
