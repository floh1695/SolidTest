using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest
{
    interface ISleep
    {
        bool IsAsleep { get; }
        void WakeUp();
        void FallAsleep();
    }
}
