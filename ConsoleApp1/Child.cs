using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Child : Person
    {

        public override int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                else
                if (value > 15)
                {
                    throw new ArgumentException("Child's age must be less than 15!");
                }
                else
                {
                    this.age = value;
                }

            }
        }

        public Child(string namE, int agE) : base(namE, agE)
        {
        }

    }
}
