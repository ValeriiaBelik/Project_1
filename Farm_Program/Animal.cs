using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm_Program
{
    public class Animal
    {
        public bool IsHealth { get; set; }
        public AnimalType AnimalType { get; set; }

        public Animal(bool isHealth, AnimalType animalType)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
