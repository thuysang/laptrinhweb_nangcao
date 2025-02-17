using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstract
{
    internal class Cow : Animal, ICanSwim
    {
        public Cow()
        {
        }
        public Cow(string name) : base(name)
        {
        }
        public override void Eat()
        {
            Console.WriteLine("Cows eat grass");
        }
        public override void Sleep()
        {
            Console.WriteLine("Cows like sleeping");
        }

        public void Swim()
        {
            Console.WriteLine("Cows can Swim");
        }
    }
}