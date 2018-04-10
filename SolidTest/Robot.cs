using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest
{
    class Robot : Entity, IRest, IPet, ISayHello
    {
        public string VersionNumber { get; set; } = "";

        public string OwnersName { get; set; } = "";

        public void StartUp() { this.IsAsleep = false; }
        public void ShutDown() { this.IsAsleep = true; }
        public void Rest() { this.ShutDown(); }
        public void UnRest() { this.StartUp(); }

        public void SayHello() { Console.WriteLine($"Hello human, I am called {this.Name}"); }

        public override string ToString()
        {
            return $"{{ Name: {this.Name}, Birthday: {this.Birthday}, VersionNumber: {this.VersionNumber}, IsAsleep: {this.IsAsleep}, OwnersName: {this.OwnersName} }}";
        }
    }
}
