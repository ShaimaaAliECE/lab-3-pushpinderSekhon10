using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Tool : Collectable
    {
        public Tool(String description):base(description) { }
        public abstract void DoAction();
        public override void AddMe(List<Collectable> lc) 
        {
            Console.WriteLine($"{base.Description} collected, congrats");
            DoAction();
        }
    }
}
