using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets
{
    public class SmallWidget : Widget, IWidgets
    {
        public SmallWidget() : base(15.00f)
        {
            Console.WriteLine("This requires Small Widgets for " + Price.ToString("C2") +" each");
        }
        public override void SetupGears(bool IsGadgetOrder)
        {
            if (!IsGadgetOrder)
            {
                Console.WriteLine("Small Widgets have: ");
                Console.WriteLine("- 2 Gears");
            }
            Gears = 2;
        }
        public override void SetupSprings(bool IsGadgetOrder)
        {
            if (!IsGadgetOrder)
            {
                Console.WriteLine("- 3 Springs.");                
            }
            Springs = 3;
        }
        public override void SetupLevers(bool IsGadgetOrder)
        {
            if (!IsGadgetOrder)
            {
                Console.WriteLine("- 1 Lever.");                
            }
            Levers = 1;
        }
    }
}