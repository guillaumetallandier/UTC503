using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morpion
{
    internal class Joueur
    {

        string name;
        int numero;
        public Joueur(string name, int numero)
        {
            this.name = name;
            this.numero = numero;
        }

        public int getNumero()
        {
            return numero;
        }

    }
}
