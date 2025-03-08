using EF_Assignment.Dbcontexts;
using EF_Assignment.Models;
namespace EF_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext iTIBbContext = new ITIDbContext();

            Department Dept01 = new Department()
            {
                dept_Id=1,
                DepartmentName="HR",
                HiringDate= new DateTime(2025, 1, 2)
            };

            Student student01 = new Student()
            {
                stud_Id = 1,
                FName = "Aly",
                LName = "Youssef",
                Address="Cairo",
                Age=20,
                StudentDepartmentId=1

            };

            iTIBbContext.Add(Dept01);
            iTIBbContext.Add(student01);

            iTIBbContext.SaveChanges();

        }
    }
}
