using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstract
{
    internal class Duck : Animal, ICanFly, ICanSwim
    {
        public Duck()
        {
        }

        public Duck(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Ducks eat rice and meat");
        }

        public void Fly()
        {
            Console.WriteLine("Ducks can fly");
        }

        public void Swim()
        {
            Console.WriteLine("Ducks can swim");
        }
    }
}