using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm_Program
{
    public class Plant
    {
        public int Count { get; set; }
        public bool IsHealth { get; set; }
        public PlantType PlantType { get; set; }

        public Plant(int count, bool isHealth, PlantType plantType)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
