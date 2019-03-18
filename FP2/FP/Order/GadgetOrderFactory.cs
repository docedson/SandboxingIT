using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class GadgetOrderFactory : OrderFactory
    {
        public override void Build()
        {
            gadgetOrder ro = new gadgetOrder(isgadgetOrder);
            ro.Build();
        }
    }
}