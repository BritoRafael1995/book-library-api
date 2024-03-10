using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Models.Model
{
    public class Book : BaseEntity
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int TotalCopies { get; set; }
        public int CopiesInUse { get; set; }
        public int TypeId { get; set; }
        public string Isbn { get; set; }
        public string Category { get; set; }
        public Author Author { get; set; }
        public BookType BookType { get; set; }
    }
}
