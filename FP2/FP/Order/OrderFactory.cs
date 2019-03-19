using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public abstract class OrderFactory : IOrder
    {
        public bool IsGadgetOrder { get; set; }

        public enum OrderMethod
        {
            Retail, Custom
        }
        public virtual void Build()
        {
        }
    }
}