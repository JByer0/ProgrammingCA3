namespace CA3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("1. Ship Reports");
                Console.WriteLine("2. Occupation Report");
                Console.WriteLine("3. Age Report");
                Console.WriteLine("4. Exit");

                Console.WriteLine("Enter Choice: ");
                choice = int.Parse(Console.ReadLine());

            } while (choice != 4);
        }
    }
}