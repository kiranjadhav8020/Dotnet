using CurdOperation_RestAPI.Data;
using CurdOperation_RestAPI.Models;
using CurdOperation_RestAPI.Service;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CurdOperation_RestAPI.Services
{
    public class StudentService : IStudentService
    {
        private ApplicationDbContext _Context;
        public StudentService(ApplicationDbContext Context) {
            _Context = Context;
        }
        public List<Student> GetAllStudent()
        {
           List<Student> result= _Context.Students.ToList();

            return result;  
        
        }

        public Student GetStudentById(int id)
        {
           Student st= _Context.Students.Find(id);
            //var st = _Context.Students.FirstOrDefault(s => s.StudentId == id);
            return st;
           
        }

        public Student CreateNewStudent(Student student)
        { 
           EntityEntry<Student> st=_Context.Students.Add(student);
            if (_Context.SaveChanges() > 0)
                return st.Entity;
            else return null;
        }

        public Student UpdateStudent(Student student) 
        {
            /*// this is modern way to do 
            _Context.Students.Update(student);
             _Context.SaveChanges(); */

           Student std= _Context.Students.Find(student.StudentId);

            if (std != null)
            {
                std.StudentId = student.StudentId;
                std.Name = student.Name;
                std.Age = student.Age;
                std.CourseId = student.CourseId;
                std.City = student.City;
                if (_Context.SaveChanges() > 0)
                {
                    return std;
                }
                else return new Student();

            }
            return new Student();
        
        }


        public Student DeleteStudent(int id)
        {

            Student std=_Context.Students.Find(id);

            if (std != null)
            {
                _Context.Students.Remove(std);
                if (_Context.SaveChanges() > 0)
                {
                    return std;
                }

            }

            return new Student();
        
        }



    }
}
