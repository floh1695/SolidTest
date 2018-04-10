using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var entities = new List<Entity>
            {
                new Human { Name = "Kiki" },
                new Human { Name = "Chuckles" },
                new Human { Name = "Nicole" },
                new Panda { Name = "Bobo" },
                new Panda { Name = "Kongo" },
                new Robot { Name = "CC76", VersionNumber = "vvM8m6e7vv" },
                new Robot { Name = "PartyBot", VersionNumber = "party7P34 PBr" }
            };

            foreach (var entity in entities) { Console.WriteLine(entity); }



            Console.ReadLine();
        }
    }
}
