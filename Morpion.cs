public class Morpion
{
	public Morpion()
	{

	}

	public int grille[3][3];
	
	public void setCase(int i,int j, int val)
    {
		this.grille [i][j] = val;
    }

	public bool ligneComplete(int i, int val)
    {
		if (this.grille[i,0] == val && this.grille[i,1]== val && this.grille[i,2]= val)
        {
			return true
        }
        else
        {
			return false;
        }
    }

	public bool colonneComplete(int i, int val)
	{
		if (this.grille[0, i] == val && this.grille[1,i] == val && this.grille[2, i] = val)
		{
			return true

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
			if (this.grille[0, 0] == val && this.grille[1, 1] == val && this.grille[2, 2] = val)
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
			if (this.grille[2, 0] == val && this.grille[1, 1] == val && this.grille[0, 2] = val)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		if (this.grille[0,1])
    }


	public bool victoire( int val)
    {
		if (this.diagonalComplete(1, val) || this.diagonalComplete(0, val || this.colonneComplete(0, val) || this.colonneComplete(1, val) || this.diagonalComplete(2, val) || this.ligneComplete(0, val) || this.ligneComplete(1, val) || this.ligneComplete(2, val)){
			return true;
        }
        else
        {
			return false;
        };
    }

	public bool CaseVide(int i, int j)
	{
		if (this.getGrille[i][j] != 0)
		{
			return false;
		}
        else
        {
			return true;
        }

	}


}
