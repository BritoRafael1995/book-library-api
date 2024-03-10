using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Models.Model
{
    public class Book : BaseEntity
    {
        [Column("book_id")]
        public int BookId { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Title { get; set; }
        [Column("total_copies")]
        public int TotalCopies { get; set; }
        [Column("copies_in_use")]
        public int CopiesInUse { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string Isbn { get; set; }
        [Column("book_type_id")]
        public int BookTypeId { get; set; }
        public List<Author> Authors { get; set; }
        public BookType BookType { get; set; }
        public List<BookCategory> Categories { get; set; }

    }
}
