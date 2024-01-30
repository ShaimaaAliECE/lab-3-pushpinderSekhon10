using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Coin : Treasure
    {
        public int Value;
        public void UpdateTotalValue() { }
        public void Display() { }
        public override void AddMe(List<Collectable> lc)
        {
        }
    }
}
