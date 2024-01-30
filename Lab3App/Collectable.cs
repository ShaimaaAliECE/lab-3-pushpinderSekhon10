using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Collectable : Displayable
    {
        String Description;
        CollectionBoard board;
        public void Display() { }
        public virtual void AddMe(List<Collectable> lc) 
        {
            Console.WriteLine(Description + "Was added");
        }
    }
}
