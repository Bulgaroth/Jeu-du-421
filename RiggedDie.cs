using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDu421
{
    class RiggedDie : Die
    {
        public override int Lancer()
        {
            int tmpRoll = rand.Next(0, 12);
            if (tmpRoll < 6) return 6;
            if (tmpRoll < 2) return 5;

            return rand.Next(1, 5);
        }
    }
}
