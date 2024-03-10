using AutoMapper;
using BookLibrary.DataStore.SQLServer.Interface;
using BookLibrary.Models;
using BookLibrary.Models.Dto;
using BookLibrary.Models.Model;
using BookLibrary.Services.Interface;

namespace BookLibrary.Services.Implementation
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task DataSeed()
        {
            var authors = new List<Author>
            {
                new Author
                {
                    FirstName = "Jane",
                    LasName = "Austen"
                },
                new Author
                {
                    FirstName = "Paulo",
                    LasName = "Coelho"
                },
                new Author
                {
                    FirstName = "Herman",
                    LasName = "Melville"
                },
                new Author
                {
                    FirstName = "Dan",
                    LasName = "Brown"
                },
                new Author
                {
                    FirstName = "J.D.",
                    LasName = "Salinger"
                },
                new Author
                {
                    FirstName = "John",
                    LasName = "Steinbeck"
                },
                new Author
                {
                    FirstName = "Harper",
                    LasName = "Lee"
                },
                new Author
                {
                    FirstName = "C.S.",
                    LasName = "Lewis"
                },
                new Author
                {
                    FirstName = "Douglas",
                    LasName = "Adams"
                },
                new Author
                {
                    FirstName = "F. Scott",
                    LasName = "Fitzgerald"
                },
                new Author
                {
                    FirstName = "Markus",
                    LasName = "Zusak"
                }
            };
            await _bookRepository.AddAuthors(authors);

            var types = new List<BookType>
            {
                new BookType
                {
                    Description = "Hardcover"
                },
                new BookType
                {
                    Description = "Paperback"
                }
            };
            await _bookRepository.AddBookTypes(types);

            var categories = new List<BookCategory>
            {
                new BookCategory
                {
                    Description = "Biography"
                },
                new BookCategory
                {
                    Description = "Fiction"
                },
                new BookCategory
                {
                    Description = "Mystery"
                },
                new BookCategory
                {
                    Description = "Non-Fiction"
                },
                new BookCategory
                {
                    Description = "Sci-Fi"
                }
            };
            await _bookRepository.AddCategories(categories);

            var Books = new List<Book>
            {
                new Book
                {
                    Title = "The Chronicles of Narnia",
                    Authors = authors.FindAll(a => a.FirstName == "C.S."),
                    TotalCopies = 100,
                    CopiesInUse = 14,
                    BookType = types.First(t => t.Description == "Paperback"),
                    Isbn =  "1234567897",
                    Categories = categories.FindAll(a => a.Description == "Sci-Fi")
                },
                new Book
                {
                    Title = "The Da Vinci Code",
                    Authors = authors.FindAll(a => a.FirstName == "Dan"),
                    TotalCopies = 50,
                    CopiesInUse = 40,
                    BookType = types.First(t => t.Description == "Paperback"),
                    Isbn =  "1234567898",
                    Categories = categories.FindAll(a => a.Description == "Sci-Fi")
                },
                new Book
                {
                    Title = "The Hitchhiker''s Guide to the Galaxy",
                    Authors = authors.FindAll(a => a.FirstName == "Douglas"),
                    TotalCopies = 50,
                    CopiesInUse = 35,
                    BookType = types.First(t => t.Description == "Paperback"),
                    Isbn =  "1234567900",
                    Categories = categories.FindAll(a => a.Description == "Non-Fiction")
                },
                new Book
                {
                    Title = "The Great Gatsby",
                    Authors = authors.FindAll(a => a.FirstName == "F. Scott"),
                    TotalCopies = 50,
                    CopiesInUse = 22,
                    BookType = types.First(t => t.Description == "Hardcover"),
                    Isbn =  "1234567894",
                    Categories = categories.FindAll(a => a.Description == "Non-Fiction")
                },
                new Book
                {
                    Title = "To Kill a Mockingbird",
                    Authors = authors.FindAll(a => a.FirstName == "Harper"),
                    TotalCopies = 75,
                    CopiesInUse = 65,
                    BookType = types.First(t => t.Description == "Paperback"),
                    Isbn =  "1234567892",
                    Categories = categories.FindAll(a => a.Description == "Fiction")
                },
                new Book
                {
                    Title = "To Kill a Mockingbird",
                    Authors = authors.FindAll(a => a.FirstName == "Harper"),
                    TotalCopies = 75,
                    CopiesInUse = 65,
                    BookType = types.First(t => t.Description == "Paperback"),
                    Isbn =  "9012345678",
                    Categories = categories.FindAll(a => a.Description == "Non-Fiction")
                },
                new Book
                {
                    Title = "Moby-Dick",
                    Authors = authors.FindAll(a => a.FirstName == "Herman"),
                    TotalCopies = 30,
                    CopiesInUse = 8,
                    BookType = types.First(t => t.Description == "Hardcover"),
                    Isbn =  "8901234567",
                    Categories = categories.FindAll(a => a.Description == "Fiction")
                },
                new Book
                {
                    Title = "The Catcher in the Rye",
                    Authors = authors.FindAll(a => a.FirstName == "J.D."),
                    TotalCopies = 50,
                    CopiesInUse = 45,
                    BookType = types.First(t => t.Description == "Hardcover"),
                    Isbn =  "1234567893",
                    Categories = categories.FindAll(a => a.Description == "Fiction")
                },
                new Book
                {
                    Title = "The Catcher in the Rye",
                    Authors = authors.FindAll(a => a.FirstName == "J.D."),
                    TotalCopies = 50,
                    CopiesInUse = 45,
                    BookType = types.First(t => t.Description == "Hardcover"),
                    Isbn =  "0123456789",
                    Categories = categories.FindAll(a => a.Description == "Non-Fiction")
                },
                new Book
                {
                    Title = "Pride and Prejudice",
                    Authors = authors.FindAll(a => a.FirstName == "Jane"),
                    TotalCopies = 100,
                    CopiesInUse = 80,
                    BookType = types.First(t => t.Description == "Hardcover"),
                    Isbn =  "1234567891",
                    Categories = categories.FindAll(a => a.Description == "Fiction")
                },
                new Book
                {
                    Title = "The Grapes of Wrath",
                    Authors = authors.FindAll(a => a.FirstName == "John"),
                    TotalCopies = 50,
                    CopiesInUse = 35,
                    BookType = types.First(t => t.Description == "Hardcover"),
                    Isbn =  "1234567899",
                    Categories = categories.FindAll(a => a.Description == "Fiction")
                },
                new Book
                {
                    Title = "The Book Thief",
                    Authors = authors.FindAll(a => a.FirstName == "Markus"),
                    TotalCopies = 75,
                    CopiesInUse = 11,
                    BookType = types.First(t => t.Description == "Hardcover"),
                    Isbn =  "1234567896",
                    Categories = categories.FindAll(a => a.Description == "Mystery")
                },
                new Book
                {
                    Title = "The Alchemist",
                    Authors = authors.FindAll(a => a.FirstName == "Paulo"),
                    TotalCopies = 50,
                    CopiesInUse = 35,
                    BookType = types.First(t => t.Description == "Hardcover"),
                    Isbn =  "1234567895",
                    Categories = categories.FindAll(a => a.Description == "Biography")
                }
            };

            await _bookRepository.AddBooks(Books);

        }

        public async Task<List<BookDto>> Search(SearchFilter filter)
        {
            var books = await _bookRepository.Search(filter);

            return _mapper.Map<List<BookDto>>(books);
        }
    }
}
