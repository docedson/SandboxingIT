using Accessories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadgets
{
    public class MediumGadgets : Gadget, IGadget
    {
        public MediumGadgets() : base(75.00f)//, Powered.Power.solar)
        {
            _defaultSwitches = 1;
            _defaultButtons = 2;
            _defaultLights = 3;

            Console.WriteLine("The selected Medium Gadget is " + Price.ToString("C2") +" each");
        }

        public override void SetupWidgets()
        {
            if (!isgadgetOrder)
            {
                Console.WriteLine("One Medium Gadget includes 2 Small Widgets, 2 Medium Widgets and 1 Large Widget standard.");
            }

            AddSmallWidgets(2);
            AddMediumWidgets(2);
            AddLargeWidgets(1);
        }

        public override void SetupLights()
        {
            String sLights;
            if (!isgadgetOrder)
            {
                Console.WriteLine("There are " + _defaultLights.ToString() + " Lights available for a Medium Gadget at " + LightPrice + " each.");
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
                Console.WriteLine("There are " + _defaultSwitches.ToString() + " Switches available for a Medium Gadget at " + SwitchPrice + " each.");
                Console.Write("However, additional Switches may be added to your order. " /*+ SwitchPrice + " each.*/ + "How many more would you like to add to your order?: ");
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
                Console.WriteLine("There are " + _defaultButtons.ToString() + " Buttons available for a Medium Gadget. for " + ButtonPrice + " each.");
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