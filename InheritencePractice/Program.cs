using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritencePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Mamall BigBrownBear = new Mamall(96.4, 480.2, "Herman", "Spain", true);
            BigBrownBear.GetInfo();
            Reptiles DragonLizard = new Reptiles(14.0, 72.6, "smokey", "Montana", true);
            DragonLizard.GetInfo();
            Console.WriteLine(DragonLizard.Sum());
            Console.WriteLine(BigBrownBear.Sum());
            Console.WriteLine(DragonLizard.GetWeight(0));
            Console.WriteLine(BigBrownBear.GetWeight(100));
        }

    }
}
