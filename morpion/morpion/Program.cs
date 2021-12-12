


namespace morpion
{
    class program
    {
        static void Main(string[] args) 
        {
            Console.Clear();
            Morpion morpion = new Morpion();
            Console.WriteLine(" 7 | 8 | 9");
            Console.WriteLine("---*---*---");
            Console.WriteLine(" 4 | 5 | 6");
            Console.WriteLine("---*---*---");
            Console.WriteLine(" 1 | 2 | 3");
            Console.WriteLine();


            Console.WriteLine("Player 1 : 1");
            Console.WriteLine("Player 2 : 2");
            Console.WriteLine();
            morpion.afficheGrille();
            bool game = false;
            bool joueur = false;
            while (!game)
            {
                if (morpion.readCase(Console.ReadLine(), joueur))
                {
                    if (joueur)
                    {
                        joueur = false;
                    }
                    else
                    {
                        joueur = true;
                    }
                }
                Console.Clear();
                Console.WriteLine("---*---*---*---*---*---*---*---*---*---*---");
                morpion.afficheGrille();
                if (!joueur)
                { 
                    game = morpion.victoire(2);
                    if (game)
                    {
                        Console.WriteLine("Bravo Joueur 2 tu gagnes !!!");
                    }
                }
                else
                {
                    game = morpion.victoire(1);
                    if (game)
                    {
                        Console.WriteLine("Bravo Joueur 1 tu gagnes !!!");
                    }
                }

                if (morpion.somme() == 13)
                {
                    Console.WriteLine("Match Nul !");
                    game = true;
                }
            }
        }
    }
}
