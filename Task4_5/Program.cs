namespace Task4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw  =new("Numbers.txt"))
            {
                for (int i = 0; i < 10; i++)
                    sw.WriteLine(i);
            }

            using StreamReader sr = new("Numbers.txt");
            List<int> numbers = new();
            while (!sr.EndOfStream)
                numbers.Add(int.Parse(sr.ReadLine()));
            Parallel.ForEach(numbers, Factorial);
            Console.ReadKey();
            Console.WriteLine($"Numbers Sum = {numbers.AsParallel().Sum(x => x)}");
            Console.WriteLine($"Numbers Min = {numbers.AsParallel().Min(x => x)}");
            Console.WriteLine($"Numbers MAx = {numbers.AsParallel().Max(x => x)}");

        }

        static void Factorial(int x)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Result {result}");
        }
    }
}