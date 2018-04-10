using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest
{
    class Panda : Entity, ISleep, IRest, IPet, ISayHello, IEat
    {
        public string OwnersName { get; set; }

        public void WakeUp() { this.IsAsleep = false; }
        public void FallAsleep() { this.IsAsleep = true; }
        public void Rest() { this.FallAsleep(); }
        public void UnRest() { this.WakeUp(); }

        public void Eat(string food) { Console.WriteLine($"The beast chows down on some {food}"); }

        public void SayHello() { Console.WriteLine($"{this.Name} waves at you"); }

        public override string ToString()
        {
            return $"{{ Name: {this.Name}, Birthday: {this.Birthday}, IsAsleep: {this.IsAsleep}, OwnersName: {this.OwnersName} }}";
        }
    }
}
