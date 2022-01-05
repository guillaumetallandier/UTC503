using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morpion
{
    abstract public class Grille
    {
        
        public Grille() {
           
        }
        //        public void afficheGrille() {}

      //  abstract public bool caseVide(int i, int j);
       // abstract public int somme();
        abstract public bool matchNul();

        abstract public bool readCase(int val);
        abstract public bool writeCase(int val,int joueur);

        abstract public bool ligneComplete(int i, int val);
        abstract public bool colonneComplete(int i, int val);
        abstract public bool diagonalComplete(int i, int val);
        abstract public void afficheGrille();
        abstract public bool victoire(int i, int j,int val);

    }
}
