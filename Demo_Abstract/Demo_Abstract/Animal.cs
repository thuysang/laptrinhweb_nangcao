using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstract
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public virtual void Sleep()
        {
            Console.WriteLine("Animals like sleeping");
        }
        public Animal()
        {

        }
        public Animal(string name)
        {
            Name = name;
        }
        public abstract void Eat(); //pt trừu tượng, ko thể cài đặt ở lớp cha
        //các lớp con kế thừa tự cài đặt.
    }
}