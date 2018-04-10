using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest
{
    abstract class Animal : Entity, ISleep, IEat
    {
        public void WakeUp()
        {
            Console.WriteLine($"{this.Name} wakes up");
            this.UnRest();
        }
        public void FallAsleep()
        {
            Console.WriteLine($"{this.Name} falls asleep");
            this.Rest();
        }

        public abstract void Eat(string food);
    }
}
