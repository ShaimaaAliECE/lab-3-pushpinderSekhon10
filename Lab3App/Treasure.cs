using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Treasure : Collectable
    {
        public int Score;
        public void UpdateTotalScore() { this.Score = 0; }
        public override void AddMe(List<Collectable> lc)
        {
            Console.WriteLine("Was added");
        }
    }
}
