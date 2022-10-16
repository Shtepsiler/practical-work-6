using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class STime
    {


        private int min;
        private int sec;

        public int Min
        {
            get { return min; }
            set { 
            if(value >=0&&value<=14)
                {min= value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Song minutes should be between 0 and 14.");
                }
            }
        }

        public int Sec
        {
            get { return sec; }
            set
            {
                if (value >= 0 && value <= 59)
                {
                    sec = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Song seconds should be between 0 and 59.");
                }
            }
        }






        public STime( string time)
        {
            string[] sekv = time.Split(":");

            this.Min = int.Parse(sekv[0]);
            this.Sec = int.Parse(sekv[1]);

        }

        /*      public STime(int min, int sec)
              {
                  this.Min = min;
                  this.Sec = sec;
              }
          */
        public void Stime(string time)
        {
            string[] sekv = time.Split(":");

            this.Min = int.Parse(sekv[0]);
            this.Sec = int.Parse(sekv[1]);

        }

          public void Stime(int min, int sec)
              {
                  this.Min = min;
                  this.Sec = sec;
              }
          


    }
}
