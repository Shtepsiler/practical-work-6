using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Student : Human
    {
        private string fnumber;

        public string Fnumber
        {
            get { return fnumber; }

            set
            {
                if (value.Length > 5 && value.Length < 10)
                {
                    fnumber = value;
                }
                else {
                    throw new ArgumentException("Invalid faculty number!");
                }

            }
        }


        public Student(string name, string surname, string number)
        {
            this.Fname = name;
            this.Lname = surname;
            this.Fnumber = number;
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"First Name: {Fname}")
            .AppendLine($"Last Name: {Lname}")
            .AppendLine($"Faculty number: {Fnumber}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }




    }
}
