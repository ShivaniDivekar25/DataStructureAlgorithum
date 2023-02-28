namespace DataStructureAlgorithum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to data structure algorithum");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:Permutation of string");
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
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}