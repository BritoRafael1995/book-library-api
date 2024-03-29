﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BookLibrary.Models.Model
{
    public class BookType : BaseEntity
    {
        [Column("book_type_id")]
        public int BookTypeId { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Description { get; set; }
        public List<Book> Books { get; set; }
    }
}