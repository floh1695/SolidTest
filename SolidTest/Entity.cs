using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest
{
    abstract class Entity
    {
        public string Name = "";
        public DateTime Birthday = DateTime.Now;
        public bool IsAsleep { get; protected set; } = false;
    }
}
