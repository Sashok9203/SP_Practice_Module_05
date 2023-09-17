namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 3;
            int end = 8;
            var result = Parallel.For(start, end + 1, MulltiTable);
            Console.WriteLine("Multiplication Tables has been saved ");
        }

        static void MulltiTable(int number)
        {
            using StreamWriter sw = new($"{number}_Table.txt");
            for (int i = 1; i <= 10; i++)
                sw.WriteLine($"{number} * {i} = {number * i}");
        }
    }
}