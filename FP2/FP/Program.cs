using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gadgets;
using Order;

namespace WagCorp
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Start page to find order type
            Console.WriteLine("Welcome to the Wag Corp's Gadgets & Widgets online shop!");
            Console.Write("Where all your gadget and widget needs are met!");
            Console.WriteLine(" ");
            Console.WriteLine("Please let us know if you would like to place a Gadget (1) or a Widget (2) order:");
            int orderType = Convert.ToInt32(Console.ReadLine());

            if (orderType == 1)
            {
                OrderFactory gadgetOrder = new GadgetOrderFactory();
                gadgetOrder.Build();
            }
            else if (orderType == 2)
            {
                OrderFactory widgetOrder = new WidgetOrderFactory();
                widgetOrder.Build();
            }
            else
            {
                Console.WriteLine("You did not enter a valid option. Please start over.");
                Console.WriteLine(" ");
            }
        }
    }
}