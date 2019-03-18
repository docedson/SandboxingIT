using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets
{
    public class MediumWidget : Widget, IWidgets
    {
        public MediumWidget() : base(250.00f)
        {
            Console.WriteLine("This requires Medium Widgets for " + Price.ToString("C2")+" each");
        }
        public override void SetupGears(bool isgadgetOrder)
        {
            if (!isgadgetOrder)
            {
                Console.WriteLine("Medium Widget have: ");
                Console.WriteLine("- 4 Gears");
            }
            Gears = 4;
        }
        public override void SetupSprings(bool isgadgetOrder)
        {
            if (!isgadgetOrder)
            {
                Console.WriteLine("- 5 Springs.");
            }
            Springs = 5;
        }
        public override void SetupLevers(bool isgadgetOrder)
        {
            if (!isgadgetOrder)
            {
                Console.WriteLine("- 3 Levers.");                
            }
            Levers = 3;
        }
    }
}