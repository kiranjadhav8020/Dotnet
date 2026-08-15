using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CurdOperation_RestAPI.Models
{
    [Table("STUDENT")]
    public class Student
    {
        [Key]
        [Column("STUDENT_ID")]
        public int StudentId { get; set; }

        [Column("NAME")]
        public string Name { get; set; } = string.Empty;

        [Column("CITY")]
        public string City { get; set; } = string.Empty;

        [Column("AGE")]
        public int Age { get; set; }

        [Column("COURSE_ID")]
        public int CourseId { get; set; }
    }
}
