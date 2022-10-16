using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Song : Artist
    {
        private string name;
        public override string Name 
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 3 && value.Length < 30) { name = value; }
                else
                {
                    throw new ArgumentException("Song name should be between 3 and 30 symbols.");
                }

            } 
        }

      
        private STime time;

        public Song(string name, string stime)
        {
            this.Name = name;
            try
            {
                this.time.Stime(stime);
            }
            catch 
            {
                throw new ArgumentException("Invalid song length.");
            }
        }


    }
}
