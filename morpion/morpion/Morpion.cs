using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Morpion
{
	public Morpion()
	{
		this.grille = new int[,]
		{{ 0,0,0},
		{ 0,0,0},
		{ 0,0,0}
			};
	}
	public int[,] grille;

	public int somme()
    {
		int somme = 0;
		for(int i = 0; i < 3; i++)
        {
			for(int j = 0; j < 3; j++)
            {
				somme += this.grille[i,j];
            }
        }
	
		return somme;
    }

	public bool readCase( string val, bool player)
    {
		
		int valeur;
		int valueKey = int.Parse(val);
		if (player)
        {
			
			valeur = 2;
        }
        else
        {
			
			valeur = 1;
        }
		switch (valueKey)
		{
			case 1:
				if (this.caseVide(2, 0)) { 
					this.grille[2, 0] = valeur;
					return true;
                }
                else
                {
					Console.WriteLine("Case déjà prise !");
					return false;
                }
				break;
			case 2:
				if (this.caseVide(2, 1))
				{
					this.grille[2, 1] = valeur;
					return true;
				}
				else
				{
					Console.WriteLine("Case déjà prise !");
					return false;
				}
				break;
			case 3:
				if (this.caseVide(2, 2))
				{
					this.grille[2, 2] = valeur;
					return true;
				}
				else
				{
					Console.WriteLine("Case déjà prise !");
					return false;
				}
				break;
			case 4:
				if (this.caseVide(1, 0))
				{
					this.grille[1, 0] = valeur;
					return true;
				}
				else
				{
					Console.WriteLine("Case déjà prise !");
					return false;
				}
				break;
			case 5:
				if (this.caseVide(1, 1))
				{
					this.grille[1, 1] = valeur;
					return true;
				}
				else
				{
					Console.WriteLine("Case déjà prise !");
					return false;
				}
				break;
			case 6:
				if (this.caseVide(1, 2))
				{
					this.grille[1, 2] = valeur;
					return true;
				}
				else
				{
					Console.WriteLine("Case déjà prise !");
					return false;
				}
				break;
			case 7:
				if (this.caseVide(0, 0))
				{
					this.grille[0, 0] = valeur;
					return true;
				}
				else
				{
					Console.WriteLine("Case déjà prise !");
					return false;
				}
				break;
			case 8:
				if (this.caseVide(0, 1))
				{
					this.grille[0, 1] = valeur;
					return true;
				}
				else
				{
					Console.WriteLine("Case déjà prise !");
					return false;
				}
				break;
			case 9:
				if (this.caseVide(0, 2))
				{
					this.grille[0, 2] = valeur;
					return true;
				}
				else
				{
					Console.WriteLine("Case déjà prise !");
					return false;

				}
				break;
		}
		
		return false;
	}



	public void setCase(int i, int j, int val)
	{
		this.grille[i, j] = val;

	}

	public bool ligneComplete(int i, int val)
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

	public bool colonneComplete(int i, int val)
	{
		if ((this.grille[0,i] == val) && (this.grille[1, i] == val) && (this.grille[2, i] == val))
		{
			
			return true;

		}
		else
		{
			return false;
		}
	}

	public bool diagonalComplete(int i, int val)
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


	public bool victoire(int val)
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

	public bool caseVide(int i, int j)
	{
		if (this.grille[i,j] != 0)
		{
			return false;
		}
		else
		{
			return true;
		}

	}

	public void afficheGrille()
    {
		string[,] tab = new string[,]
		{{ " "," "," "},
		{ " "," "," "},
		{ " "," "," "}
			};

		for (int i = 0; i <3; i++)
        {
			for(int j = 0; j <3; j++)
            {
				if (this.grille[i,j] !=0) {
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
