using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoAsign546
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Ny" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();

                Console.WriteLine("Added to database.");
            }
            Console.ReadLine();
        }
    }
}
