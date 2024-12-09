using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGestures
{

    public interface IAnimal : IMakeNoise, IMakeTrick

    {
        public string Type { get; }
        public string Name { get; }

        void Perform();
    }
}
