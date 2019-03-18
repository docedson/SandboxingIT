using Accessories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadgets
{
    public class LargeGadgets : Gadget, IGadget
    {
        public LargeGadgets() : base(100.00f)//, Powered.Power.generator)
        {
            _defaultButtons = 4;
            _defaultSwitches = 2;
            _defaultLights = 5;
            Console.WriteLine("The selected Large Gadget is " + Price.ToString("C2") +" each");
        }

        public override void SetupWidgets()
        {
            if (!isgadgetOrder)
            {
                Console.WriteLine("A Large Gadget includes 3 Small Widgets, 6 Medium Widgets and 3 Large Widgets as standard.");
            }

            AddSmallWidgets(3);
            AddMediumWidgets(6);
            AddLargeWidgets(3);
        }

        public override void SetupLights()
        {
            String sLights;
            if (!isgadgetOrder)
            {
                Console.WriteLine("There are " + _defaultLights.ToString() + " Lights available for a Large Gadget at " + LightPrice + " each.");
                Console.Write("However, additional Lights may be added to your order. " /*+ LightPrice*/ + "How many more would you like to add to your order?: ");
                sLights = Console.ReadLine();
                Lights = int.Parse(sLights) + _defaultLights;
            }
            else
            {
                Lights = _defaultLights;
            }
        }

        public override void SetupSwitches()
        {
            String sSwitches;

            if (!isgadgetOrder)
            {
                Console.WriteLine("There are " + _defaultSwitches.ToString() + " Switches available for a Large Gadget at " + SwitchPrice + " each.");
                Console.Write("However, additional Switches may be added to your order. " /*+ SwitchPrice + " each.*/ +"How many more would you like to add to your order?: ");
                sSwitches = Console.ReadLine();
                Switches = int.Parse(sSwitches) + _defaultSwitches;
            }
            else
            {
                Switches = _defaultSwitches;
            }
        }

        public override void SetupButtons()
        {
            String sButtons;

            if (!isgadgetOrder)
            {
                Console.WriteLine("There are " + _defaultButtons.ToString() + " Buttons available for a Large Gadget. for " + ButtonPrice + " each.");
                Console.Write("However, additional Buttons may be added to your order. " /*+ ButtonPrice*/ + "How many more would you like to add to your order?: ");
                sButtons = Console.ReadLine();
                Buttons = int.Parse(sButtons) + _defaultButtons;
            }
            else
            {
                Buttons = _defaultButtons;
            }
        }
    }
}