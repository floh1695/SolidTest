using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest
{
    class Human : Animal
    {
        public override void Eat(string food) { Console.WriteLine($"I'm eating some {food}"); }

        public override void SayHello() { Console.WriteLine($"Hello, I am {this.Name}"); }

        public List<IPet> Pets = new List<IPet>();
        public void Adopt(IPet pet) {
            pet.OwnersName = this.Name;
            this.Pets.Add(pet);
        }

        public override string ToString()
        {
            return $"{{ Name: {this.Name}, Birthday: {this.Birthday}, IsAsleep: {this.IsAsleep}, Pets: [ " + String.Join(",", Pets.Select(p => p.ToString())) + " ] }}";
        }

    }
}
