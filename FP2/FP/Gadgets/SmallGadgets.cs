﻿using Accessories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadgets
{
    public class SmallGadgets : Gadget, IGadget
    {
        public SmallGadgets() : base(50.00f)//, Powered.Power.battery)
        {
            _defaultSwitches = 1;
            _defaultButtons = 2;
            //_defaultLights = 0;

            Console.WriteLine("The selected Small Gadget is " + Price.ToString("C2") +" each");
        }

        public override void SetupWidgets()
        {
            if (!isgadgetOrder)
            {
                Console.WriteLine("A Small Gadget includes 1 Small Widget and 1 Medium Widget standard.");
            }

            AddSmallWidgets(1);
            AddMediumWidgets(1);
        }

        public override void SetupLights()
        {
            if (!isgadgetOrder)
            {
                Console.WriteLine("No Lights are available for a Small Gadget");
            }
            Lights = _defaultLights;
        }

        public override void SetupSwitches()
        {
            if (!isgadgetOrder)
            {
                Console.WriteLine("There are " + _defaultSwitches.ToString() + " Switches available for a Small Gadget at " + SwitchPrice + " each.");
            }
            Switches = _defaultSwitches;
        }

        public override void SetupButtons()
        {
            String sButtons;

            if (!isgadgetOrder)
            {
                Console.WriteLine("There are " + _defaultButtons.ToString() + " Buttons available for a Small Gadget at " + ButtonPrice + " each.");
                Console.Write("However, additional Buttons may be added to your order. " /*+ ButtonPrice */+ "How many more would you like to add to your order?: ");
                sButtons = Console.ReadLine();
                Buttons = int.Parse(sButtons) + _defaultButtons;
            }
            Buttons = _defaultButtons;
        }
    }
}