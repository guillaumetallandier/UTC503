using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morpion
{
    



    

    public class Puissance4
    {
        
        public Puissance4()
        { 
        }

        public Joueur game(GrillePuissance grille, Joueur j1, Joueur j2)
        {
            


            Console.WriteLine("Player 1 : 1");
            Console.WriteLine("Player 2 : 2");
            Console.WriteLine();
            grille.afficheGrille();
            bool victoire = false;
            Joueur jTmp = j1;
            while (!victoire)
            {
                string tempoAffichage = Console.ReadLine();
                Console.Clear();
                int tmp = grille.graviter(tempoAffichage, jTmp);

                switch (tmp)
                {
                    case 0:
                        // le joueur a pu joueur 
                        if (jTmp.getNumero()==j1.getNumero())
                        {
                            jTmp = j2;
                        }
                        else
                        {
                            jTmp = j1;
                        }
                        break;
                    case -1:
                        // le joueur n'a pu joueur 

                        break;
                    case 1:
                        // le joueur a gagné la partie !
                        victoire = true;
                        break;
                }
               grille.afficheGrille();

                

            }

            return jTmp;

        }
    }

}
