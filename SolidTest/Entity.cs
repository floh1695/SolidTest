using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest
{
    abstract class Entity : IRest, ISayHello
    {
        public string Name = "";
        public DateTime Birthday = DateTime.Now;

        public bool IsAsleep { get; protected set; } = false;
        public void Rest()
        {
            Console.WriteLine($"Entity {this.Name} is now resting");
            this.IsAsleep = true;
        }
        public void UnRest()
        {
            Console.WriteLine($"Entity {this.Name} is unresting");
            this.IsAsleep = false;
        }

        public abstract void SayHello();
    }
}
