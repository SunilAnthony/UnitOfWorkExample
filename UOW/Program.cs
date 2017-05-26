using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW.DAL;

namespace UOW
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new PlutoContext()))
            {
                var courses = unitOfWork.Courses.GetAll();
                Console.WriteLine("List of Courses:");
                foreach (var item in courses)
                {
                    Console.WriteLine("Id: {0}, Name: {1}, Level: {2}, Price: {3}", item.Id, item.Name, item.Level, item.FullPrice);
                }
            }
                Console.ReadLine();
        }
    }
}
