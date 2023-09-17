namespace Task1_2

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                Display,
                () =>
                {
                    Console.WriteLine($"Task executing {Task.CurrentId}");
                    Thread.Sleep(3000);
                    Console.WriteLine($"Task ended  {Task.CurrentId}");
                },
                () => Factorial(5),
                () => DigitsCount(1234567),
                () => DigitsSum(1234567));

            Console.ReadLine();
        }

        static void Display()
        {
            Console.WriteLine($"Task executing {Task.CurrentId}");
            Thread.Sleep(3000);
            Console.WriteLine($"Task ended {Task.CurrentId}");
        }

        static void Factorial(int x)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Task executing {Task.CurrentId}");
            Thread.Sleep(3000);
            Console.WriteLine($"Result {result}");
        }

        static void DigitsCount(int x)
        {
            Console.WriteLine($"Task executing {Task.CurrentId}");
            Thread.Sleep(3000);
            Console.WriteLine($"Number {x} has {x.ToString().Length} digits");
        }

        static void DigitsSum(int x)
        {
            Console.WriteLine($"Task executing {Task.CurrentId}");
            Thread.Sleep(3000);
            Console.WriteLine($"Sum of digits {x} = {x.ToString().Select(x => x - '0').Sum(x => x)}");
        }
        
    }
}