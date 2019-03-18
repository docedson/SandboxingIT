using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gadgets;

namespace Order
{
    public class gadgetOrder : IOrder
    {
        private ArrayList _Gadgets = new ArrayList();
        private int _iNumberOfSmallGadgets = 0;
        private int _iNumberOfMediumGadgets = 0;
        private int _iNumberOfLargeGadgets = 0;

        private string _sColorDefaultGadget;
        private string _sColorDefaultWidget;
        //private string _sDefaultPower;

        public bool isgadgetOrder { get; set; }

        public gadgetOrder(bool bgadgetOrder)
        {
            isgadgetOrder = bgadgetOrder;
        }

        public void Build()
        {
            try
            {
                string sResponse;
                string sResponse2;
                string sResponse3;

                Console.Write("How many Small Gadgets would you like?: ");
                sResponse = Console.ReadLine();
                _iNumberOfSmallGadgets = int.Parse(sResponse);
                if (_iNumberOfSmallGadgets > 0)
                {
                    Console.WriteLine("How would like your Gadgets decorated?: (1) Painted, (2) Chrome Plated, (3) Plain: ");
                    int sPainted = Convert.ToInt32(Console.ReadLine());

                    if (sPainted == 1)
                    {
                        Console.WriteLine("Your Gadgets will be painted.");
                        Console.Write("What color would you like them: (1) Black, (2) Green, (3) Brown, (4) Blue, (5) Yellow, (6) Violet, (7) Red, (8) Gold?: ");
                        _sColorDefaultGadget = Console.ReadLine();
                        Console.WriteLine(" ");
                    }
                    else if (sPainted == 2)
                    {
                        Console.WriteLine("Your Gadgets will be plated");
                    }
                    else if (sPainted == 3)
                    {
                        Console.WriteLine("Your Gadgets will be plain.");
                    }

                    Console.WriteLine("A Small Gadget is powered by the included Battery.");
                    SetupSmallGadgets();
                    Console.WriteLine(" ");                    
                }

                Console.Write("How many Medium Gadgets would you like?: ");
                sResponse2 = Console.ReadLine();
                _iNumberOfMediumGadgets = int.Parse(sResponse2);
                if (_iNumberOfMediumGadgets > 0)
                {
                    Console.WriteLine("How would like your Gadgets decorated?: (1) Painted, (2) Chrome Plated, (3) Plain: ");
                    int sPainted = Convert.ToInt32(Console.ReadLine());

                    if (sPainted == 1)
                    {
                        Console.Write("What color would you like them: (1) Black, (2) Green, (3) Brown, (4) Blue, (5) Yellow, (6) Violet, (7) Red, (8) Gold?: ");
                        _sColorDefaultGadget = Console.ReadLine();
                        Console.WriteLine(" ");
                    }
                    else if (sPainted == 2)
                    {
                        Console.WriteLine("Your Gadgets will be plated.");
                    }
                    else if (sPainted == 3)
                    {
                        Console.WriteLine("Your Gadgets will be plain.");
                    }

                    Console.WriteLine("A Medium Gadget is powered by the included Solar Battery.");
                    SetupMediumGadgets();
                    Console.WriteLine(" ");                    
                }                

                Console.Write("How many Large Gadgets would you like?: ");
                sResponse3 = Console.ReadLine();
                _iNumberOfLargeGadgets = int.Parse(sResponse3);
                if (_iNumberOfLargeGadgets > 0)
                {
                    Console.WriteLine("How would like your Gadgets decorated?: (1) Painted, (2) Chrome Plated, (3) Plain: ");
                    int sPainted = Convert.ToInt32(Console.ReadLine());

                    if (sPainted == 1)
                    {
                        Console.Write("What color would you like them: (1) Black, (2) Green, (3) Brown, (4) Blue, (5) Yellow, (6) Violet, (7) Red, (8) Gold?: ");
                        _sColorDefaultGadget = Console.ReadLine();
                        Console.WriteLine(" ");
                    }
                    else if (sPainted == 2)
                    {
                        Console.WriteLine("Your Gadgets will be plated.");
                    }
                    else if (sPainted == 3)
                    {
                        Console.WriteLine("Your Gadgets will be plain.");
                    }

                    Console.WriteLine("A Large Gadget is powered by the included Generator.");
                    SetupLargeGadgets();
                    Console.WriteLine(" ");                   
                }
                else
                {
                    Console.WriteLine("You did not enter a valid option. Please try again.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error has occurred " + e.Message);
                return;
            }

            GetOrderSummary();
        }

        private void SetupSmallGadgets()
        {
            Gadget gadget = null;
            for (int ii = 0; ii < _iNumberOfSmallGadgets; ii++)
            {
                gadget = new SmallGadgets();
                SetupGadget(gadget);
            }
        }

        private void SetupMediumGadgets()
        {
            Gadget gadget = null;
            for (int ii = 0; ii < _iNumberOfMediumGadgets; ii++)
            {
                gadget = new MediumGadgets();
                SetupGadget(gadget);
            }
        }

        private void SetupLargeGadgets()
        {
            Gadget gadget = null;
            for (int ii = 0; ii < _iNumberOfLargeGadgets; ii++)
            {
                gadget = new LargeGadgets();
                SetupGadget(gadget);
            }
        }

        private void SetupGadget(Gadget gadget)
        {
            gadget.isgadgetOrder = true;
            gadget.SetupPaintedDefault(_sColorDefaultGadget);
            gadget.sDefaultWidgetColor = _sColorDefaultWidget;
            gadget.SetupWidgets();
            gadget.SetupSwitches();
            gadget.SetupButtons();
            gadget.SetupLights();
            gadget.SetupPower();
            _Gadgets.Add(gadget);
        }

        private void GetOrderSummary()
        {
            int iWidGears = 0;
            int iWidSprings = 0;
            int iWidLevers = 0;
            int iWidgets = 0;

            int iTotalWidGears = 0;
            int iTotalWidSprings = 0;
            int iTotalWidLevers = 0;
            int iTotalWidgets = 0;

            int iTotalButtons = 0;
            int iTotalLights = 0;
            int iTotalSwitches = 0;

            float fTotalOrderPrice = 0.0f;

            Console.WriteLine();

            foreach (Gadget g in _Gadgets)
            {
                ((Gadget)g).GetWidgetOrderSummary(out iWidgets, out iWidGears, out iWidSprings, out iWidLevers);
                iTotalWidGears += iWidGears;
                iTotalWidSprings += iWidSprings;
                iTotalWidLevers += iWidLevers;
                iTotalWidgets += iWidgets;

                iTotalButtons += ((Gadget)g).Buttons;
                iTotalLights += ((Gadget)g).Lights;
                iTotalSwitches += ((Gadget)g).Switches;

                fTotalOrderPrice += ((Gadget)g).GetGadgetOrderTotalPrice();
            }

            Console.WriteLine("-------Order Summary-------");

            Console.WriteLine("Total Gadgets  : {0, 5} {1, 5}", (_iNumberOfSmallGadgets + _iNumberOfMediumGadgets + _iNumberOfLargeGadgets).ToString(), " that are painted " + _sColorDefaultGadget);

            Console.WriteLine("Total Butttons : {0, 5}", iTotalButtons.ToString());
            Console.WriteLine("Total Lights   : {0, 5}", iTotalLights.ToString());
            Console.WriteLine("Total Switches : {0, 5}", iTotalSwitches.ToString());

            Console.WriteLine("Total Widgets  : {0, 5} {1, 5}", iTotalWidgets.ToString(), " that are painted " + _sColorDefaultWidget);
            Console.WriteLine("Total Gears    : {0, 5}", iTotalWidGears.ToString());
            Console.WriteLine("Total Springs  : {0, 5}", iTotalWidSprings.ToString());
            Console.WriteLine("Total Levers   : {0, 5}", iTotalWidLevers.ToString());
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Sub Total Price              : {0, 20}", fTotalOrderPrice.ToString("C2"));
            Console.WriteLine("Shipping Cost                : {0, 20}", "$25.00");
            fTotalOrderPrice += 25.00f;
            Console.WriteLine("Total Order & Shipping Price : {0, 20}", fTotalOrderPrice.ToString("C2"));
        }
    }
}