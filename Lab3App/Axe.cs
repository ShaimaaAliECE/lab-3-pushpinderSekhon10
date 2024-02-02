using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Axe : Tool
    {
        public Axe(String description):base(description) { }
        public override void Display() { Console.WriteLine($"Axe {base.Description} is displayed"); }
        public override void DoAction() { Console.WriteLine($"Axe is used"); }
    }
}
