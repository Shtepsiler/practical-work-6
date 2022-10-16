using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            try { 
            Console.WriteLine("write a student");
            string first = Console.ReadLine();


           string[] subs = first.Split(' ');

            Student student = new Student(subs[0],subs[1],subs[2]);
            Console.WriteLine("write a worker");

            first = Console.ReadLine();
             subs = first.Split(' ');
            Worker worker = new Worker(subs[0], subs[1], double.Parse(subs[2]), double.Parse(subs[3]));

            Console.WriteLine(student);
            Console.WriteLine(worker);
        } 
            catch (ArgumentException ae) 
            {
                Console.WriteLine(ae.Message);
            }
}
    }
}
