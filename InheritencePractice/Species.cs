using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritencePractice
{
    class Species
    {
       // private Double weight;
        //private Double height;
        //private string name;
        //private string habitat;
        //private bool hasTail;
        public  double Weight { get; set; }
        public double Height { get; set; }
        public string Name { get; set; }
        public string Habitat { get; set; }
        public bool HasTail { get; set; }
        public virtual void GetInfo()
        {
            Console.WriteLine("{0} is {1} pounds and {2} inches tall lives in {3}", Name, Weight, Height, Habitat);
        }
        public Double Sum()
        {
            
            double sum = Weight + Height;
            return sum;
        }
        public virtual double GetWeight(double num)
        {

            return Weight;
        }
    }
}
