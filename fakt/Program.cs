namespace fakt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("n = ");

            while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("Rossz érték!\n");
                Console.WriteLine("n = ");
            }

            int f = 1;
            for (int i = 2; i<= n; i++)
            {
                f *= i;
            }

            Console.WriteLine("n! = " + f);
        }
    }
}