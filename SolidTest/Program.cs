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
                new Human { Name = "Notso Justo" },
                new Panda { Name = "Bobo" },
                new Panda { Name = "Kongo" },
                new Robot { Name = "CC76", VersionNumber = "vvM8m6e7vv" },
                new Robot { Name = "PartyBot", VersionNumber = "party7P34 PBr" }
            };

            entities.ForEach(entity => Console.WriteLine(entity));
            entities.ForEach(entity =>
            {
                entity.Rest();
                entity.UnRest();
                entity.SayHello();
            });

            var animals = new List<Animal>(entities.OfType<Animal>());
            animals.ForEach(animal =>
            {
                animal.FallAsleep();
                animal.WakeUp();
                animal.Eat("generic animal feed");
            });

            var humans = new List<Human>(entities.OfType<Human>());
            humans.ForEach(human => human.Eat("hamburgers"));

            var pets = new List<IPet>(entities.OfType<IPet>());
            var humansAndPets = new List<Tuple<Human, IPet>>(
                    humans.Zip(pets, (human, pet) => new Tuple<Human, IPet>(human, pet))
                );
            humansAndPets.ForEach(humanPetPair => humanPetPair.Item1.Adopt(humanPetPair.Item2));
            pets.ForEach(pet => Console.WriteLine($"A poor beast is owned by {pet.OwnersName}"));

            var pandas = new List<Panda>(entities.OfType<Panda>());
            pandas.ForEach(panda => panda.Eat("bamboo"));

            var robots = new List<Robot>(entities.OfType<Robot>());
            robots.ForEach(robot =>
            {
                robot.ShutDown();
                robot.StartUp();
            });

            entities.ForEach(entity => Console.WriteLine(entity));

            Console.ReadLine();
        }
    }
}
