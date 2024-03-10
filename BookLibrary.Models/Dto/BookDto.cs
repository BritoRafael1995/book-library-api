using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Models.Dto
{
    public class BookDto
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public List<string> Authors { get; set; }
        public int TotalCopies { get; set; }
        public int CopiesInUse { get; set; }
        public string Type { get; set; }
        public string Isbn { get; set; }
        public List<string> Categories { get; set; }

    }
}
