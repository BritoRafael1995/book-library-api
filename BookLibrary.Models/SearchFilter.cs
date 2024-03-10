using BookLibrary.Models.enums;

namespace BookLibrary.Models
{
    public class SearchFilter
    {
        public EnumSearchParameter Parameter { get; set; }
        public string Value { get; set; }
    }
}
