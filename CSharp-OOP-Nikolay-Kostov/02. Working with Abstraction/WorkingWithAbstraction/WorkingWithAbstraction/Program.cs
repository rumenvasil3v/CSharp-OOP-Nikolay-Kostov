namespace WorkingWithAbstraction
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write(new string(' ', n - i));
                
                for (int j = 1; j <= i; j++)
                {
                    if (j == i)
                    {
                        Console.Write('*');
                        break;
                    }

                    Console.Write("*.");
                }

                Console.WriteLine();
            }

            for (int i = 1; i <= n; i++)
            {
                if (i == n)
                {
                    Console.Write('*');
                    break;
                }

                Console.Write("*.");
            }

            Console.WriteLine();

            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write(new string(' ', i));

                for (int j = 1; j <= n - i; j++)
                {
                    if (j == n - i)
                    {
                        Console.Write('*');
                        break;
                    }

                    Console.Write("*.");
                }

                Console.WriteLine();
            }
        }
    }
}