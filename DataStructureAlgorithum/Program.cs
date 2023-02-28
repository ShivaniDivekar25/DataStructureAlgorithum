namespace DataStructureAlgorithum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to data structure algorithum");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:Permutation of string\n2:Binary search\n3:Insertion Sort\n4:Anagram\n5:Bubble Sort\n6:Prime number within range");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Hello, World!");
                    String s = "ABC";
                    String answer = "";
                    Console.Write("\nAll possible strings are : ");
                    PermutationOfString.Permute(s, answer);
                    break;
                case 2:
                    string[] arr = new string[] { "abc", "def", "ghi", "jkl" };
                    Array.Sort(arr);
                    Console.WriteLine("The elements of Sorted Array");
                    BinarySearch.display(arr);
                    object s1 = "mno";
                    BinarySearch.result(arr, s1);
                    object s2 = "def";
                    BinarySearch.result(arr, s2);
                    break;
                case 3:
                    string[] names = { "Shivani", "Malhar", "Prasanna", "Shraddha" };
                    InsertionSort.InsertSort(names);
                    foreach (var item in names)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case 4:
                    Anagram.Anagrams();
                    break;
                case 5:
                    int[] array = { 5, 9, 4, 6, 8 };
                    BubbleSort.bubbleSort(array);
                    Console.WriteLine("Sorted array");
                    BubbleSort.printArray(array);
                    break;
                case 6:
                    PrimeNumberWithinRange.FindPrimeNumbers();
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}