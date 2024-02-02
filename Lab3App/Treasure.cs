using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Treasure : Collectable
    {
        public int Score;
        public Treasure(String description, int score) : base(description) { 
            Score = score;
        }
        public void UpdateTotalScore() { Board.TotalScore += Score; }
        public override void AddMe(List<Collectable> lc)
        {
            Console.WriteLine($"{base.Description} collected, congrats!!!!!");
            UpdateTotalScore();
            Console.WriteLine($"Total score is updated to: {Board.TotalScore}");
        }
    }
}
