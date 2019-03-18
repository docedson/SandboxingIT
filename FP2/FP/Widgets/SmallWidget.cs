using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets
{
    public class SmallWidget : Widget, IWidgets
    {
        public SmallWidget() : base(100.00f)
        {
            Console.WriteLine("This requires Small Widgets for " + Price.ToString("C2") +" each");
        }
        public override void SetupGears(bool isgadgetOrder)
        {
            if (!isgadgetOrder)
            {
                Console.WriteLine("Small Widgets have: ");
                Console.WriteLine("- 2 Gears");
            }
            Gears = 2;
        }
        public override void SetupSprings(bool isgadgetOrder)
        {
            if (!isgadgetOrder)
            {
                Console.WriteLine("- 3 Springs.");                
            }
            Springs = 3;
        }
        public override void SetupLevers(bool isgadgetOrder)
        {
            if (!isgadgetOrder)
            {
                Console.WriteLine("- 1 Lever.");                
            }
            Levers = 1;
        }
    }
}