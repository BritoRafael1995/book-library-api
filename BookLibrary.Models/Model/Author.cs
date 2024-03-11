using System.ComponentModel.DataAnnotations.Schema;

namespace BookLibrary.Models.Model
{
    public class Author : BaseEntity
    {
        [Column("author_id")]
        public int AuthorId { get; set; }
        [Column("first_name", TypeName = "varchar(50)")]
        public string FirstName { get; set; }
        [Column("last_name", TypeName = "varchar(50)")]
        public string LastName { get; set; }
        public List<Book> Books { get; set; }
    }
}