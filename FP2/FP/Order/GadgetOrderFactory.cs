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
            GadgetOrder go = new GadgetOrder(IsGadgetOrder);
            go.Build();
        }
    }
}