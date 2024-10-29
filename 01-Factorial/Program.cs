namespace _01_Factorial
{
    internal class Program
    {
        private static int Factorial(int num)
        => num >1 ? num * Factorial(num-1) : num;

        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(3));
            Console.ReadLine();
        }
    }
}
