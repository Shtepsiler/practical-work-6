using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
namespace ConsoleApp3
{
    internal class Human
    {
       protected string fname;
       protected string lname;
       
        public string Fname
        {
            get { return fname; }

            set
            {
                if (!(value.Length > 3 ))
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }
                else
                if(!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
                else { fname = value; }

            }
        }

        public string Lname
        {
            get { return lname; }

            set
            {
                if (!(value.Length > 2))
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }
                else

                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }
                else { lname = value; }

            }
        }

    }
}
