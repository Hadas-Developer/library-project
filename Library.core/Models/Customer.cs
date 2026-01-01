using System.ComponentModel.DataAnnotations;

namespace Library.Core.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }  
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public int NumBookLimit { get; set; }
        public List<Book> Books { get; set; }
    }
}
