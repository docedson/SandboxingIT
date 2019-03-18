using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class WidgetOrderFactory : OrderFactory
    {
        public override void Build()
        {
            widgetOrder co = new widgetOrder(isgadgetOrder);
            co.Build();
        }
    }
}