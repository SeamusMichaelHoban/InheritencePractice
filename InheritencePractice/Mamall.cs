using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritencePractice
{
    class Mamall : Species

    {
        public Mamall(double weight, Double height, string name, string habitat, bool hasTail)
        {
            this.Weight = weight;
            this.Height = height;
            this.Name = name;
            this.Habitat = habitat;
            this.HasTail = hasTail;
        }
        public override double GetWeight(double num)
        {
            num = num + Weight;
            return num;
        }
    }
}
