using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest
{
    class Panda : Animal, IPet
    {
        public string OwnersName { get; set; }

        public override void Eat(string food) { Console.WriteLine($"The beast chows down on some {food}"); }

        public override void SayHello() { Console.WriteLine($"{this.Name} waves at you"); }

        public override string ToString()
        {
            return $"{{ Name: {this.Name}, Birthday: {this.Birthday}, IsAsleep: {this.IsAsleep}, OwnersName: {this.OwnersName} }}";
        }
    }
}
