using System.ComponentModel.DataAnnotations.Schema;

namespace EntitySample.Models
{
    [Table("phonebook")]
    public class Phonebook
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
