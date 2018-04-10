using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest
{
    class Robot : Entity, IPet
    {
        public string VersionNumber { get; set; } = "";

        public string OwnersName { get; set; } = "";

        public void StartUp()
        {
            Console.WriteLine($"{this.Name} boots up");
            this.UnRest();
        }
        public void ShutDown()
        {
            Console.WriteLine($"{this.Name} boots down");
            this.Rest();
        }

        public override void SayHello() { Console.WriteLine($"Hello human, I am called {this.Name}"); }

        public override string ToString()
        {
            return $"{{ Name: {this.Name}, Birthday: {this.Birthday}, VersionNumber: {this.VersionNumber}, IsAsleep: {this.IsAsleep}, OwnersName: {this.OwnersName} }}";
        }
    }
}
