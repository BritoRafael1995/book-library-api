namespace BookLibrary.Models.Model
{
    public class Author : BaseEntity
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LasName { get; set; }
    }
}