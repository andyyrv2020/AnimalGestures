using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGestures
{

    public class Cat : Animal

    {
        public Cat(string name) : base(name)
        {
            return;
        }

        public override string MakeNoise()
        {
            Console.WriteLine("Meow!");
        }

        public override string MakeTrick()
        {
            Console.WriteLine("No trick for you! I'm too lazy!");
        }
    }
}
