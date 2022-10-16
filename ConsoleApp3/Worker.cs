using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Worker : Human
    {
        double weeksalary;
        public double Weeksalary {
            get { return weeksalary; }

            set {
                if (value >= 10) {
                    weeksalary = Math.Round(value,2);
                }
                else {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
            }
        }

        double hours;
        public double Hours { get { return hours; }
            set {
                if (value > 1 && value < 12)
                {
                    hours = Math.Round(value, 2);
                }
                else
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
            } 
        }
       
        public double HoursSalary { get { return Math.Round((Weeksalary/(5*Hours)), 2); } }


        public Worker(string name,string surname, double weeks,double hour)
        {
           this .Fname = name;
            this.Lname = surname;
            this.Hours = hour;
            this.Weeksalary = weeks;


        }








        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"First Name: {Fname}")
            .AppendLine($"Last Name: {Lname}")
            .AppendLine($"Week Salary: {Weeksalary}")
            .AppendLine($"Hours per day: {Hours}")
            .AppendLine($"Salary per hou: {HoursSalary}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }

    }
}
