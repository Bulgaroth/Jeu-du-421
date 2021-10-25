using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDu421
{
    class Die
    {
        protected int nbFaces;
        protected Random rand;

        int _face;
        public int face { get { return _face; } set { _face = value; } }

        public Die(int nbFaces = 6)
        {
            this.nbFaces = nbFaces;
            rand = new Random();
            Lancer();
        }

        public override string ToString() { return $"{face}"; }

        public virtual int Lancer()
        {
            face = rand.Next(1, nbFaces+1);
            return face;
        }

    }
}
