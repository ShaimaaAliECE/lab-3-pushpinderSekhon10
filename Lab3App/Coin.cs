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
        public Coin(String description, int score, int value) : base(description, score) { Value = value; }
        public void UpdateTotalValue() { Board.TotalValue += Value; }
        public override void Display() { Console.WriteLine($"Coin {base.Description} is displayed"); }
        public override void AddMe(List<Collectable> lc)
        {
            base.AddMe(lc);
        }
    }
}
