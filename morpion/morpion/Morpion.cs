using morpion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Morpion
{
	
	


	public Morpion()
	{
			
	}


	public bool game(Grille grille, Joueur j1, Joueur j2) 
    {
        grille.afficheGrille();
        Joueur jTmp = j1;
        bool victoire = false;
        int val = int.Parse(Console.ReadLine());
        while (!victoire)
        {
            if (grille.readCase(val))
            {
                grille.writeCase(val, jTmp.getNumero()); // je ne sais pas s'il faut envoyer le numero ou le joueur entier ) 
                victoire = grille.victoire(0, 0, val);
                if (!victoire)
                {
                    if (jTmp.getNumero() == j1.getNumero())
                    {
                        jTmp = j2;
                    }
                    else
                    {
                        jTmp = j1;
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("---*---*---*---*---*---*---*---*---*---*---");
            grille.afficheGrille();
            if (grille.matchNul())
            {
                Console.WriteLine("Match Nul !");
                victoire = true;
            }
        }
        return false;
    }
	
	

	
		
}
