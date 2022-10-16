using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Person
    {
      protected string name;
      protected int age;

        public virtual string Name { 
            get { return this.name; }
            set
            {
                if (value.Length<3)
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public virtual int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                else
                {
                    this.age = value;
                }
            }
        }

                public Person() { }
        public Person(string namE,int agE)
        {
            this.name = namE;
            this.age = agE;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder(); 
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}", this.Name, this.Age));
            return stringBuilder.ToString();
        }
    }
}
