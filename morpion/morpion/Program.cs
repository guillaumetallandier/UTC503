


namespace morpion
{
    class program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("vous voulez jouez ou Morpion : 1 ou Puissance4 : 2");
            if (Console.ReadLine() == "1")
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
            }else
            {
                Console.Clear();
                Puissance4 puissance = new Puissance4();
     


                Console.WriteLine("Player 1 : 1");
                Console.WriteLine("Player 2 : 2");
                Console.WriteLine();
                puissance.afficheGrille();
                bool game = false;
                bool joueur = false;
                while (!game)
                {
                    string tempoAffichage = Console.ReadLine();
                    Console.Clear();
                    int tmp = puissance.graviter(tempoAffichage,joueur);
                    
                    switch (tmp)
                    {
                        case 0:
                            // le joueur a pu joueur 
                            if (joueur)
                            {
                                joueur = false;
                            }
                            else
                            {
                                joueur = true;
                            }
                            break;
                        case -1:
                            // le joueur n'a pu joueur 

                            break;
                        case 1:
                            // le joueur a gagné la partie !
                            game = true;
                            break;
                    }
                    puissance.afficheGrille();


                }

            }
        }
    }
}
