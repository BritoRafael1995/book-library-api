using System.ComponentModel.DataAnnotations.Schema;

namespace BookLibrary.Models.Model
{
    public class BookCategory : BaseEntity
    {
        [Column("category_id")]
        public int CategoryId { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Description { get; set; }
        public List<Book> Books { get; set; }
    }
}