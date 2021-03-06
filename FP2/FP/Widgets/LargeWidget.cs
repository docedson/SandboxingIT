﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets
{
    public class LargeWidget : Widget, IWidgets
    {
        public LargeWidget() : base(25.00f)
        {
            Console.WriteLine("This requires Large Widgets for " + Price.ToString("C2") +"each");
        }
        public override void SetupGears(bool IsGadgetOrder)
        {
            if (!IsGadgetOrder)
            {
                Console.WriteLine("Large Widgets contain: ");
                Console.WriteLine("- 9 Gears");
            }
            Gears = 9;
        }
        public override void SetupSprings(bool IsGadgetOrder)
        {
            if (!IsGadgetOrder)
            {
                Console.WriteLine("- 4 Springs.");
            }
            Springs = 4;
        }
        public override void SetupLevers(bool IsGadgetOrder)
        {
            if (!IsGadgetOrder)
            {
                Console.WriteLine("- 2 Levers.");                
            }
            Levers = 2;
        }
    }
}