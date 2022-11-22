using System.ComponentModel.DataAnnotations.Schema;

namespace EntitySample.Models
{
    [Table("students")]
    public class Student
    {
        public int Id
        {
            get;
            set;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
