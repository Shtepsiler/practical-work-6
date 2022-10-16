using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Artist
    {
        private string name;
        List<Song> songs;

        public virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                if(value.Length > 3&& value.Length < 20) { name = value; }
                else
                {
                    throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
                }

            }
        }






    }
}
