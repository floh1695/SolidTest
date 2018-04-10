using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest
{
    class Human : Entity, ISleep, IRest, ISayHello, IEat
    {
        public void WakeUp() { this.IsAsleep = false; }
        public void FallAsleep() { this.IsAsleep = true; }
        public void Rest() { this.FallAsleep(); }
        public void UnRest() { this.WakeUp(); }

        public void Eat(string food) { Console.WriteLine($"I'm eating some {food}"); }

        public void SayHello() { Console.WriteLine($"Hello, I am {this.Name}"); }

        public List<IPet> Pets = new List<IPet>();
        public void Adopt(IPet pet) { }

        public override string ToString()
        {
            return $"{{ Name: {this.Name}, Birthday: {this.Birthday}, IsAsleep: {this.IsAsleep}, Pets: [ " + String.Join(",", Pets.Select(p => p.ToString())) + " ] }}";
        }

    }
}
