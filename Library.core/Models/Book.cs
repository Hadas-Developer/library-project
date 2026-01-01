using System.ComponentModel.DataAnnotations;

namespace Library.Core.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }
        public string Genre { get; set; }
    }
}
