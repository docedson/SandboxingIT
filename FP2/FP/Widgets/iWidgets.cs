﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets
{
    public interface IWidgets
    {
        void SetupGears(bool isgadgetOrder);
        void SetupSprings(bool isgadgetOrder);
        void SetupLevers(bool isgadgetOrder);
    }
}