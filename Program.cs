namespace JustePrix
{    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voulez-vous jouer au Juste Prix ? (o/n)");
            string? j = Console.ReadLine() ?? "n";
            int r, n = 0, v;
            if (j.ToLower().StartsWith('o'))
            {
                r = (new Random()).Next(1, 11);
                for (v = 3; v > 0; v--)
                {
                    Console.WriteLine("Il vous reste {0:D} vies.", v);
                    Console.WriteLine("Choississez un nombre entre 1 et 10: ");
                    n = int.Parse(Console.ReadLine() ?? "0");
                    if (n > r)
                    {
                        Console.WriteLine("Plus Petit");
                    }
                    else if (n < r)
                    {
                        Console.WriteLine("Plus Grand");
                    }
                    else
                    {
                        Console.WriteLine("Gagné ! Le nombre était {0:D}", r);
                        break;
                    }
                }
                if (n != r)
                {
                    Console.WriteLine("Vous n'avez plus de vie, le nombre était {0:D}.", r);
                }
            }
            else
            {
                Console.WriteLine("Dommage");
            }
        }
    }
}