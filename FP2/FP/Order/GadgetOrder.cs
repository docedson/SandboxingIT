using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gadgets;

namespace Order
{
    public class GadgetOrder : IOrder
    {
        private ArrayList _Gadgets = new ArrayList();
        private int _iNumberOfSmallGadgets = 0;
        private int _iNumberOfMediumGadgets = 0;
        private int _iNumberOfLargeGadgets = 0;

        private string _sColorDefaultGadget1;
        private string _sColorDefaultGadget2;
        private string _sColorDefaultGadget3;       

        public bool IsGadgetOrder { get; set; }

        public GadgetOrder(bool bGadgetOrder)
        {
            IsGadgetOrder = bGadgetOrder;
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
                    Console.Write("Choose an option for the Gadget to be decorated: (1) Painted, (2) Chrome Plated, (3) Plain: ");
                    int sPainted = Convert.ToInt32(Console.ReadLine());

                    switch (sPainted)
                    {
                        case 1:

                            Console.Write("What color would you like: (1) Black, (2) Green, (3) Brown, (4) Blue, (5) Yellow, (6) Violet, (7) Red, (8) Gold?: ");
                            int sColor = Convert.ToInt32(Console.ReadLine());

                            switch (sColor)
                            {
                                case 1:
                                    _sColorDefaultGadget1 = "painted Black";
                                    break;
                                case 2:
                                    _sColorDefaultGadget1 = "painted Green";
                                    break;
                                case 3:
                                    _sColorDefaultGadget1 = "painted Brown";
                                    break;
                                case 4:
                                    _sColorDefaultGadget1 = "painted Blue";
                                    break;
                                case 5:
                                    _sColorDefaultGadget1 = "painted Yellow";
                                    break;
                                case 6:
                                    _sColorDefaultGadget1 = "painted Violet";
                                    break;
                                case 7:
                                    _sColorDefaultGadget1 = "painted Red";
                                    break;
                                case 8:
                                    _sColorDefaultGadget1 = "painted Gold";
                                    break;
                            }
                            break;
                        case 2:
                            _sColorDefaultGadget1 = "Chrome Plated";
                            break;
                        case 3:
                            _sColorDefaultGadget1 = "Not Decorated";
                            break;
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
                    Console.Write("Choose an option for the Gadget to be decorated: (1) Painted, (2) Chrome Plated, (3) Plain: ");
                    int sPainted = Convert.ToInt32(Console.ReadLine());

                    switch (sPainted)
                    {
                        case 1:

                            Console.Write("What color would you like: (1) Black, (2) Green, (3) Brown, (4) Blue, (5) Yellow, (6) Violet, (7) Red, (8) Gold?: ");
                            int sColor = Convert.ToInt32(Console.ReadLine());

                            switch (sColor)
                            {
                                case 1:
                                    _sColorDefaultGadget2 = "painted Black";
                                    break;
                                case 2:
                                    _sColorDefaultGadget2 = "painted Green";
                                    break;
                                case 3:
                                    _sColorDefaultGadget2 = "painted Brown";
                                    break;
                                case 4:
                                    _sColorDefaultGadget2 = "painted Blue";
                                    break;
                                case 5:
                                    _sColorDefaultGadget2 = "painted Yellow";
                                    break;
                                case 6:
                                    _sColorDefaultGadget2 = "painted Violet";
                                    break;
                                case 7:
                                    _sColorDefaultGadget2 = "painted Red";
                                    break;
                                case 8:
                                    _sColorDefaultGadget2 = "painted Gold";
                                    break;
                            }
                            break;
                        case 2:
                            _sColorDefaultGadget2 = "Chrome Plated";
                            break;
                        case 3:
                            _sColorDefaultGadget2 = "Not Decorated";
                            break;
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
                    Console.Write("Choose an option for the Gadget to be decorated: (1) Painted, (2) Chrome Plated, (3) Plain: ");
                    int sPainted = Convert.ToInt32(Console.ReadLine());

                    switch (sPainted)
                    {
                        case 1:

                            Console.Write("What color would you like: (1) Black, (2) Green, (3) Brown, (4) Blue, (5) Yellow, (6) Violet, (7) Red, (8) Gold?: ");
                            int sColor = Convert.ToInt32(Console.ReadLine());

                            switch (sColor)
                            {
                                case 1:
                                    _sColorDefaultGadget3 = "painted Black";
                                    break;
                                case 2:
                                    _sColorDefaultGadget3 = "painted Green";
                                    break;
                                case 3:
                                    _sColorDefaultGadget3 = "painted Brown";
                                    break;
                                case 4:
                                    _sColorDefaultGadget3 = "painted Blue";
                                    break;
                                case 5:
                                    _sColorDefaultGadget3 = "painted Yellow";
                                    break;
                                case 6:
                                    _sColorDefaultGadget3 = "painted Violet";
                                    break;
                                case 7:
                                    _sColorDefaultGadget3 = "painted Red";
                                    break;
                                case 8:
                                    _sColorDefaultGadget3 = "painted Gold";
                                    break;
                            }
                            break;
                        case 2:
                            _sColorDefaultGadget3 = "Chrome Plated";
                            break;
                        case 3:
                            _sColorDefaultGadget3 = "Not Decorated";
                            break;
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
            gadget.IsGadgetOrder = true;
            gadget.SetupPaintedDefault(_sColorDefaultGadget1);
            gadget.SetupPaintedDefault(_sColorDefaultGadget2);
            gadget.SetupPaintedDefault(_sColorDefaultGadget3);
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

            Console.WriteLine("Total Gadgets  : {0, 5} {1, 5}", (_iNumberOfSmallGadgets + _iNumberOfMediumGadgets + _iNumberOfLargeGadgets).ToString(), " that are " + _sColorDefaultGadget1 + ", " + _sColorDefaultGadget2 +", and " +_sColorDefaultGadget3);
            Console.WriteLine("Total Butttons : {0, 5}", iTotalButtons.ToString());
            Console.WriteLine("Total Lights   : {0, 5}", iTotalLights.ToString());
            Console.WriteLine("Total Switches : {0, 5}", iTotalSwitches.ToString());

            Console.WriteLine("Total Widgets  : {0, 5}", iTotalWidgets.ToString());
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