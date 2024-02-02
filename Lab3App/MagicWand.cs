using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class MagicWand : Tool
    {
        public MagicWand(String description):base(description) { }
        public override void Display() { Console.WriteLine($"Magic wand {base.Description} is displayed"); }
        public override void DoAction() { Console.WriteLine($"Magic wand is used"); }
    }
}
