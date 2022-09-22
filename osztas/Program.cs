namespace osztas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("a = ");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ujra!");
                Console.WriteLine("a = ");
            }

            Console.WriteLine("b = ");
            while (!int.TryParse(Console.ReadLine(), out b) || b == 0)
            {
                Console.WriteLine("Ujra!");
                Console.WriteLine("b = ");
            }

            int o, m;
            o = 0;
            if (a >= 0)
            {
                if (b > 0)
                {
                    while (a >= b)
                    {
                        o++;
                        a -= b;
                    }
                }

                else
                {
                    while (a >= (-b))
                    {
                        o--;
                        a += b;
                    }
                }
            }

            else
            {
                if (b > 0)
                {
                    while ((-a) >= b)
                    {
                        o--;
                        a += b;
                    }
                }

                else
                {
                    while ((-a) >= (-b))
                    {
                        o++;
                        a -= b;
                    }
                }
            }

            m = a;
            Console.WriteLine("b " + o + "-szor van meg a-ban. A maradék " + m + ".");
        }
    }
}