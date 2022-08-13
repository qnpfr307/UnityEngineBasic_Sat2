using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example06_RollADice
{
    public class Tileinfo_Star : Tileinfo
    {
        public int starValue = 3;

        public override void OnTile()
        {
            base.OnTile();
            starValue++;
        }
    }
}
