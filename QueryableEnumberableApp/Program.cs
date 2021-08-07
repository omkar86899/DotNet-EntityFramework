using QueryableEnumberableApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryableEnumberableApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            StudentDbContext db = new StudentDbContext();

            //AddStudents(db);
            QueryableCase1(db);
            QueryableCase2(db);

        }

        private static void QueryableCase2(StudentDbContext db)
        {
            var firstNameStartingWithS = db.Students
                                      .Where(s => s.FullName.StartsWith("S"))
                                      .AsEnumerable()
                                      .Select(s => new
                                      {
                                          FirstName = s.FullName.Split(' ')[0],
                                          Cgpa = s.Cgpa
                                      });
            Console.WriteLine(firstNameStartingWithS);

            var firstNameStartWithSList = firstNameStartingWithS.ToList();

            foreach (var s in firstNameStartWithSList)
            {
                Console.WriteLine(s.FirstName);
                Console.WriteLine(s.Cgpa);
            }
        }

        private static void QueryableCase1(StudentDbContext db)
        {
            var nameStartingWithS = db.Students
                                      .Where(s => s.FullName.StartsWith("S"))
                                      .Select(s => new
                                      {
                                          s.FullName,
                                          s.Cgpa
                                      });
            Console.WriteLine(nameStartingWithS);

            var nameStartWithSList = nameStartingWithS.ToList();

            foreach(var s in nameStartWithSList)
            {
                Console.WriteLine(s.FullName);
                Console.WriteLine(s.Cgpa);
            }
        }

        private static void AddStudents(StudentDbContext db)
        {
            db.Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                FullName = "Sachin Tendulkar",
                Cgpa = 7.5f
            }); ;
            db.Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                FullName = "Siddhesh Yellaram",
                Cgpa = 8.1f
            });
            db.Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                FullName = "Omkar Bhosale",
                Cgpa = 6.5f
            });
            db.Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                FullName = "Vaibhav Kamble",
                Cgpa = 7.8f
            });

            db.SaveChanges();
        }
    }
}
