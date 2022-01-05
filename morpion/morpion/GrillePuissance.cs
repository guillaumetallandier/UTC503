using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morpion
{
    public class GrillePuissance : Grille
    {

        public GrillePuissance()
        {
            this.grille = new int[,]
           {{0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0}
            };
        }


        public int[,] grille;



        public override bool matchNul()
        {
            int val = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    val += this.grille[i, j];
                }
            }

            if (val == 74)
            {
                return true;
            }
            return false;
        }

        public bool ligneComplete(int i, int j, int val)
        {

            if (j - 3 >= 0)
            {
                if ((this.grille[i, j] == val) && (this.grille[i, j - 1] == val) && (this.grille[i, j - 2] == val) && (this.grille[i, j - 3] == val))
                {
                    return true;
                }
            }
            if (j - 2 >= 0 && j + 1 <= 6)
            {
                if ((this.grille[i, j + 1] == val) && (this.grille[i, j] == val) && (this.grille[i, j - 1] == val) && (this.grille[i, j - 2] == val))
                {
                    return true;
                }
            }
            if (j - 1 >= 0 && j + 2 <= 6)
            {
                if ((this.grille[i, j + 2] == val) && (this.grille[i, j + 1] == val) && (this.grille[i, j] == val) && (this.grille[i, j - 1] == val))
                {
                    return true;
                }
            }
            if (j + 3 <= 6)
            {
                if ((this.grille[i, j + 3] == val) && (this.grille[i, j + 2] == val) && (this.grille[i, j + 1] == val) && (this.grille[i, j] == val))
                {
                    return true;
                }
            }

            return false;
        }

        public bool colonneComplete(int i, int j, int val)
        {

            if (i - 3 >= 0)
            {
                if ((this.grille[i, j] == val) && (this.grille[i - 1, j] == val) && (this.grille[i - 2, j] == val) && (this.grille[i - 3, j] == val))
                {
                    return true;
                }
            }
            if (i - 2 >= 0 && i + 1 <= 6)
            {
                if ((this.grille[i + 1, j] == val) && (this.grille[i, j] == val) && (this.grille[i - 1, j] == val) && (this.grille[i - 2, j] == val))
                {
                    return true;
                }
            }
            if (i - 1 >= 0 && i + 2 <= 6)
            {
                if ((this.grille[i + 2, j] == val) && (this.grille[i + 1, j] == val) && (this.grille[i, j] == val) && (this.grille[i - 1, j] == val))
                {
                    return true;
                }
            }
            if (i + 3 <= 6)
            {
                if ((this.grille[i + 3, j] == val) && (this.grille[i + 2, j] == val) && (this.grille[i + 1, j] == val) && (this.grille[i, j] == val))
                {
                    return true;
                }
            }
            return false;
        }

        public bool diagonalGHComplete(int i, int j, int val)
        {

            if (i - 3 >= 0 && j - 3 >= 0)
            {
                if ((this.grille[i, j] == val) && (this.grille[i - 1, j - 1] == val) && (this.grille[i - 2, j - 2] == val) && (this.grille[i - 3, j - 3] == val))
                {
                    return true;
                }
            }
            if (i - 2 >= 0 && j - 2 >= 0 && i + 1 <= 6 && j + 1 <= 0)
            {
                if ((this.grille[i + 1, j + 1] == val) && (this.grille[i, j] == val) && (this.grille[i - 1, j - 1] == val) && (this.grille[i - 2, j - 2] == val))
                {
                    return true;
                }
            }
            if (i - 1 >= 0 && j - 1 >= 0 && i + 2 <= 6 && j + 2 <= 0)
            {
                if ((this.grille[i + 2, j + 2] == val) && (this.grille[i + 1, j + 1] == val) && (this.grille[i, j] == val) && (this.grille[i - 1, j - 1] == val))
                {
                    return true;
                }
            }
            if (i + 3 <= 6 && j + 3 <= 0)
                if ((this.grille[i + 3, j + 3] == val) && (this.grille[i + 2, j + 2] == val) && (this.grille[i + 1, j + 1] == val) && (this.grille[i, j] == val))
                {
                    return true;
                }

            return false;
        }

        public bool diagonalGBComplete(int i, int j, int val)
        {

            if (j - 3 >= 0 && i + 3 <= 6)
            {
                if ((this.grille[i, j] == val) && (this.grille[i + 1, j - 1] == val) && (this.grille[i + 2, j - 2] == val) && (this.grille[i + 3, j - 3] == val))
                {
                    return true;
                }
            }
            if (i - 1 >= 0 && i + 2 <= 6 && j - 2 >= 0 && j + 1 <= 6)
            {
                if ((this.grille[i - 1, j + 1] == val) && (this.grille[i, j] == val) && (this.grille[i + 1, j - 1] == val) && (this.grille[i + 2, j - 2] == val))
                {
                    return true;
                }
            }
            if (i - 2 >= 0 && i + 1 <= 6 && j - 2 >= 0 && j + 2 <= 6)
            {
                if ((this.grille[i - 2, j + 2] == val) && (this.grille[i - 1, j + 1] == val) && (this.grille[i, j] == val) && (this.grille[i + 1, j - 1] == val))
                {
                    return true;
                }
            }
            if (i - 3 >= 0 && j + 3 <= 6)
            {
                if ((this.grille[i - 3, j + 3] == val) && (this.grille[i - 2, j + 2] == val) && (this.grille[i - 1, j + 1] == val) && (this.grille[i, j] == val))
                {
                    return true;
                }
            }
            return false;
        }


        public int graviter(string j, Joueur player)
        {
            int i = 0;
            int valeurKey = int.Parse(j) - 1;

            if (valeurKey > 7)
            {
                return -1;
            }
           
            while (this.grille[i, valeurKey] == 0 && i < 6)
            {
                if (i < 6)
                {
                    i++;
                }

            }
            if (this.grille[i, valeurKey] == 0)
            {

                this.grille[i, valeurKey] = player.getNumero();
            }
            else
            {
                if (i - 1 < 0)
                {
                    Console.WriteLine("Colone pleine !");
                    return -1;
                }
                this.grille[i - 1, valeurKey] = player.getNumero();
            }
            if (this.victoire(i - 1, valeurKey, player.getNumero()))
            {
                return 1;
            };
            return 0;
        }

        public override bool victoire(int i, int j, int val)
        {
            if (this.diagonalGBComplete(i, j, val) || this.diagonalGHComplete(i, j, val) || this.colonneComplete(i, j, val) || this.ligneComplete(i, j, val))
            { 
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void afficheGrille()
        {
            string[,] tab = new string[,]
            {{ " "," "," ", " "," "," "," "},
            { " "," "," ", " "," "," "," "},
            { " "," "," ", " "," "," "," "},
            { " "," "," ", " "," "," "," "},
            { " "," "," ", " "," "," "," "},
            { " "," "," ", " "," "," "," "},
            { " "," "," ", " "," "," "," "}

                };

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (this.grille[i, j] != 0)
                    {
                        tab[i, j] = this.grille[i, j].ToString(); ;
                    }
                }

            }
            Console.WriteLine("| 1 | 2 | 3 | 4 | 5 | 6 | 7 |");
            Console.WriteLine("*---*---*---*---*---*---*---*");
            Console.WriteLine("| " + tab[0, 0] + " | " + tab[0, 1] + " | " + tab[0, 2] + " | " + tab[0, 3] + " | " + tab[0, 4] + " | " + tab[0, 5] + " | " + tab[0, 6] + " | ");
            Console.WriteLine("| " + tab[1, 0] + " | " + tab[1, 1] + " | " + tab[1, 2] + " | " + tab[1, 3] + " | " + tab[1, 4] + " | " + tab[1, 5] + " | " + tab[1, 6] + " | ");
            Console.WriteLine("| " + tab[2, 0] + " | " + tab[2, 1] + " | " + tab[2, 2] + " | " + tab[2, 3] + " | " + tab[2, 4] + " | " + tab[2, 5] + " | " + tab[2, 6] + " | ");
            Console.WriteLine("| " + tab[3, 0] + " | " + tab[3, 1] + " | " + tab[3, 2] + " | " + tab[3, 3] + " | " + tab[3, 4] + " | " + tab[3, 5] + " | " + tab[3, 6] + " | ");
            Console.WriteLine("| " + tab[4, 0] + " | " + tab[4, 1] + " | " + tab[4, 2] + " | " + tab[4, 3] + " | " + tab[4, 4] + " | " + tab[4, 5] + " | " + tab[4, 6] + " | ");
            Console.WriteLine("| " + tab[5, 0] + " | " + tab[5, 1] + " | " + tab[5, 2] + " | " + tab[5, 3] + " | " + tab[5, 4] + " | " + tab[5, 5] + " | " + tab[5, 6] + " | ");
            Console.WriteLine("| " + tab[6, 0] + " | " + tab[6, 1] + " | " + tab[6, 2] + " | " + tab[6, 3] + " | " + tab[6, 4] + " | " + tab[6, 5] + " | " + tab[6, 6] + " | ");
            Console.WriteLine("*---*---*---*---*---*---*---*");


        }
    }
}
