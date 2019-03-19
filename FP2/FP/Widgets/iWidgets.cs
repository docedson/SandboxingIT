using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets
{
    public interface IWidgets
    {
        void SetupGears(bool IsGadgetOrder);
        void SetupSprings(bool IsGadgetOrder);
        void SetupLevers(bool IsGadgetOrder);
    }
}