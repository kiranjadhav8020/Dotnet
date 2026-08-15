using CurdOperation_RestAPI.Models;

namespace CurdOperation_RestAPI.Service
{
    public interface IStudentService
    {
        public List<Student> GetAllStudent();

        public Student GetStudentById(int id);

        public Student CreateNewStudent(Student student);

        public Student UpdateStudent(Student student); 
        
        public Student DeleteStudent(int id);
    }
}
