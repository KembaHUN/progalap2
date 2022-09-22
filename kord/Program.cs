namespace kord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("x = ");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Próbáld meg újra!\n");
                Console.WriteLine("x = ");
            }

            Console.WriteLine("y = ");
            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Próbáld meg újra!\n");
                Console.WriteLine("x = ");
            }

            int p;
            /*if (x >= 0 && y >= 0)
            {
                p = 1;
            }

            else if (x < 0 && y >=0)
            {
                p = 2;
            }

            else if (x < 0 && y < 0)
            {
                p = 3;
            }

            else
            {
                p = 4;
            }*/

            if (x >= 0)
            {
                if (y >= 0)
                {
                    p = 1;
                }

                else
                {
                    p = 4;
                }
            }

            else
            {
                if (y >= 0)
                {
                    p = 2;
                }

                else
                {
                    p = 3;
                }
            }

            Console.WriteLine(p + ". siknegyed");
        }
    }
}