using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morpion
{
    internal class GrilleMorpion : Grille
    {
		public int[,] grille;


		public GrilleMorpion() {
            this.grille = new int[,]
        {{ 0,0,0},
        { 0,0,0},
        { 0,0,0}};
        }


        
		public bool caseVide(int i, int j)
		{
			if (this.grille[i, j] != 0)
			{
				return false;
			}
			else
			{
				return true;
			}

		}
		public override bool matchNul()
		{
			int somme = 0;
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					somme += this.grille[i, j];
				}
			}

			if (somme == 13)
            {
				return true;
            }

			return false;
		}
		public override bool writeCase(int i,int joueur)
		{
			
			switch (i)
			{
				case 1:
					
					this.grille[2, 0] = joueur;
					return true;
					break;
				case 2:
					this.grille[2, 1] = joueur;
					return true;
					break;
				case 3:
					this.grille[2, 2] = joueur;
					return true;
					break;
				case 4:
					this.grille[1, 0] = joueur;
					return true;
					break;
				case 5:
                    this.grille[1,1] = joueur;
					return true;
					break;
				case 6:
                    this.grille[1,2] = joueur;
					return true;
					break;
				case 7:
					this.grille[0,0] = joueur;
					return true;
					break;
				case 8:
					this.grille[0, 1] = joueur;
					return true;
					break;
				case 9:
					this.grille[0, 2] = joueur;
					return true;
					break;
			}
			return false; 
		}
		public override bool readCase(int i)
        {
			switch (i)
			{
				case 1:
					if (this.caseVide(2, 0))
					{	
						return true;
                    }
                    else
                    {
						return false;
                    }
					
					break;
				case 2:
					if (this.caseVide(2, 1))
					{

						return true ;
					}
					else
					{
						return false;
					}
					break;
				case 3:
					if (this.caseVide(2, 2))
					{
						
						return true;
					}
					else
					{
						
						return false;
					}
					break;
				case 4:
					if (this.caseVide(1, 0))
					{
						
						return true;
					}
					else
					{
			
						return false;
					}
					break;
				case 5:
					if (this.caseVide(1, 1))
					{
						
						return true;
					}
					else
					{
						
						return false;
					}
					break;
				case 6:
					if (this.caseVide(1, 2))
					{
						
						return true;
					}
					else
					{
						
						return false;
					}
					break;
				case 7:
					if (this.caseVide(0, 0))
					{
						
						return true;
					}
					else
					{
						
						return false;
					}
					break;
				case 8:
					if (this.caseVide(0, 1))
					{
						return true;
					}
					else
					{
						
						return false;
					}
					break;
				case 9:
					if (this.caseVide(0, 2))
					{
						return true;
					}
					else
					{
					
						return false;
					}
					break;
			}
			return false;
		}

        
        public override bool matchNul(int somme)
        {
            int val = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    val = this.grille[i, j];
                }
            }

            if (val != somme)
            {
                return true;
            }
            return false;
        }

		public override bool ligneComplete(int i, int val)
		{
			if ((this.grille[i, 0] == val) && (this.grille[i, 1] == val) && (this.grille[i, 2] == val))
			{

				return true;

			}
			else
			{
				return false;
			}
		}

		public override bool colonneComplete(int i, int val)
		{
			if ((this.grille[0, i] == val) && (this.grille[1, i] == val) && (this.grille[2, i] == val))
			{

				return true;

			}
			else
			{
				return false;
			}
		}

		public override bool diagonalComplete(int i, int val)
		{
			if (i == 1)
			{
				if (this.grille[0, 0] == val && this.grille[1, 1] == val && this.grille[2, 2] == val)
				{

					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				if (this.grille[2, 0] == val && this.grille[1, 1] == val && this.grille[0, 2] == val)
				{

					return true;
				}
				else
				{
					return false;
				}
			}


		}
		public override bool victoire(int i, int j,int val) //une sur utilisation de la mémoire est faite ici, les valeurs i et j ne servent a rien (cf. GrillePuisssance.victoire() )
		{
			if (this.diagonalComplete(1, val) || this.diagonalComplete(0, val) || this.colonneComplete(0, val) || this.colonneComplete(1, val) || this.colonneComplete(2, val) || this.ligneComplete(0, val) || this.ligneComplete(1, val) || this.ligneComplete(2, val))
			{

				return true;
			}
			else
			{

				return false;
			};
		}
		public override void afficheGrille()
		{
			string[,] tab = new string[,]
			{{ " "," "," "},
		{ " "," "," "},
		{ " "," "," "}
				};

			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					if (this.grille[i, j] != 0)
					{
						tab[i, j] = this.grille[i, j].ToString(); ;
					}


				}

			}
			Console.WriteLine(" " + tab[0, 0] + " | " + tab[0, 1] + " | " + tab[0, 2] + " ");
			Console.WriteLine("---*---*---");
			Console.WriteLine(" " + tab[1, 0] + " | " + tab[1, 1] + " | " + tab[1, 2] + " ");
			Console.WriteLine("---*---*---");
			Console.WriteLine(" " + tab[2, 0] + " | " + tab[2, 1] + " | " + tab[2, 2] + " ");

		}
	}
}
