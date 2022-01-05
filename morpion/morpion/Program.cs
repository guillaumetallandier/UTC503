


namespace morpion
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Joueur 1 comment vous appelez vous ? ");
            String name = Console.ReadLine();
            Joueur j1 = new Joueur(name, 1);
            Console.WriteLine("Joueur 2 comment vous appelez vous ? ");
            name = Console.ReadLine();
            Joueur j2 = new Joueur(name, 1);
            Console.WriteLine("vous voulez jouez ou Morpion : 1 ou Puissance4 : 2");



            
            if (Console.ReadLine() == "1")
            {
                Puissance4 puissance4 = new Puissance4();
                GrillePuissance grille = new GrillePuissance();
                Joueur vainqueur = puissance4.game(grille,j1,j2);
                Console.WriteLine("Joueur " + vainqueur.getNumero() + " à gagné !!!");
            }
            else
            {
                Morpion morpion = new Morpion();
                GrilleMorpion grille = new GrilleMorpion();
                Joueur vainqueur = morpion.game(grille, j1, j2);
                Console.WriteLine("Joueur " + vainqueur.getNumero() + " à gagné !!!");
            }
        }
    }
}
