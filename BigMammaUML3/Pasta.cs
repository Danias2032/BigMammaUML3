using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    public class Pasta : MenuItem
    {
        public bool Dressing { get; set; }

        public Pasta(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool dressing) : base(number, name, description, price, type, isVegan, isOrganic)
        {
            Dressing = dressing;
        }
        public override string PrintInfo()
        {
            return base.PrintInfo() + $"Dressing {Dressing}";
        }
    }
}
