using Gadgets;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class widgetOrder : IOrder
    {
        public bool isgadgetOrder { get; set; }

        public widgetOrder(bool bgadgetOrder)
        {
            isgadgetOrder = bgadgetOrder;
        }
        public void Build()
        {
            ArrayList Gadgets = new ArrayList();
            Gadget gadget = null;
            float fTotalOrderPrice = 0.0f;
            float fRunningTotalOrderPrice = 0.0f;

            do
            {
                Console.Write("Enter the Widget size you would like: (1) Small, (2) Medium, or (3) Large: ");
                int sGadgetOrder = Convert.ToInt32(Console.ReadLine());

                switch (sGadgetOrder)
                {
                    case 1:                    
                        gadget = new SmallGadgets();
                        break;

                    case 2:                    
                        gadget = new MediumGadgets();
                        break;

                    case 3:                    
                        gadget = new LargeGadgets();
                        break;

                    default:
                        Console.WriteLine("You did not choose an available size. Please choose again.");
                        break;
                }

                if ((sGadgetOrder == 1) || (sGadgetOrder == 2) || (sGadgetOrder == 3)) ;
                {
                    gadget.SetupPainted();
                    gadget.SetupWidgets();
                    gadget.SetupSwitches();
                    gadget.SetupButtons();
                    gadget.SetupLights();
                    gadget.SetupPower();
                    Gadgets.Add(gadget);
                }

                Console.Write("Would you like to add additional Gadgets to your order? Please choose \"Y\" for yes or \"N\" for no: ");
                string sResponse = (Console.ReadLine().ToUpper());

                if (sResponse.Equals("Y") == false)
                {
                    break;
                }
            }
            while (true);

            Console.WriteLine();
            Console.WriteLine("Your order summary containing " + Gadgets.Count.ToString() + " Gadget(s):");

            foreach (IGadget g in Gadgets)
            {
                if (g.GetType() == typeof(SmallGadgets))
                {
                    Console.WriteLine("- Small Gadget for " + ((Gadget)g).Price.ToString("C2"));
                }
                else if (g.GetType() == typeof(MediumGadgets))
                {
                    Console.WriteLine("- Medium Gadget for " + ((Gadget)g).Price.ToString("C2"));
                }
                else if (g.GetType() == typeof(LargeGadgets))
                {
                    Console.WriteLine("- Large Gadget for " + ((Gadget)g).Price.ToString("C2"));
                }
                //Console.WriteLine(" ");
                Console.WriteLine("Which includes the following items: ");
                Console.WriteLine("- " + ((Gadget)g).Buttons + " Buttons.");
                Console.WriteLine("- " + ((Gadget)g).Lights + " Lights.");
                Console.WriteLine("- " + ((Gadget)g).Switches + " Switches.");
                //Console.WriteLine("- " + ((Gadget)g).GetPower() + " for " + ((Gadget)g).GetGadgetPowerPrice());
                ((Gadget)g).GetPainted();

                ((Gadget)g).GetWidgetOrderSummary();
                fTotalOrderPrice += ((Gadget)g).GetGadgetOrderTotalPrice();
                Console.WriteLine("Total Gadget and Widget Price: \t{0,20}", fTotalOrderPrice.ToString("C2"));
                fRunningTotalOrderPrice += fTotalOrderPrice;
                fTotalOrderPrice = 0.0f;
            }

            Console.WriteLine();
            Console.WriteLine("Sub Total Order Price        : \t{0,20}", fRunningTotalOrderPrice.ToString("C2"));
            Console.WriteLine("Shipping Cost                : \t{0,20}", "$25.00");
            fRunningTotalOrderPrice += 25.00f;
            Console.WriteLine("Grand Order & Shipping Price : \t{0,20}", fRunningTotalOrderPrice.ToString("C2"));
        }
    }
}