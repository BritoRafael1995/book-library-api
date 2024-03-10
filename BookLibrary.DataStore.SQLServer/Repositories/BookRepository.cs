using BookLibrary.DataStore.SQLServer.Interface;
using BookLibrary.Models;
using BookLibrary.Models.enums;
using BookLibrary.Models.Model;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.DataStore.SQLServer.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _context;

        public BookRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Book>> Search(SearchFilter filter)
        {
            if (!string.IsNullOrWhiteSpace(filter.Value))
            {
                switch (filter.Parameter)
                {
                    case EnumSearchParameter.Title:
                        return await SearchByTitle(filter.Value);
                    case EnumSearchParameter.Author:
                        return await SearchByAuthor(filter.Value);
                    case EnumSearchParameter.ISBN:
                        return await SearchByIsbn(filter.Value);

                }
            }

            return await _context.Books
                .Include(b => b.BookType)
                .Include(b => b.Authors)
                .Include(b => b.Categories).ToListAsync();
        }

        private async Task<List<Book>> SearchByIsbn(string value)
        {
            return await _context.Books
                .Include(b => b.BookType)
                .Include(b => b.Authors)
                .Include(b => b.Categories)
                .Where(b => b.Isbn.Contains(value)).ToListAsync();
        }

        private async Task<List<Book>> SearchByAuthor(string value)
        {
            return await _context.Books
                .Include(b => b.BookType)
                .Include(b => b.Authors)
                .Include(b => b.Categories)
                .Where(b => b.Authors.Any(a => $"{a.FirstName} {a.LasName}".Contains(value))).ToListAsync();
        }

        private async Task<List<Book>> SearchByTitle(string value)
        {
            return await _context.Books
                .Include(b => b.BookType)
                .Include(b => b.Authors)
                .Include(b => b.Categories)
                .Where(b => b.Title.Contains(value)).ToListAsync();
        }

        public async Task AddAuthors(List<Author> authors)
        {
            _context.Authors.AddRangeAsync(authors);
            _context.SaveChanges();
        }

        public async Task AddCategories(List<BookCategory> categories)
        {
            _context.BookCategories.AddRangeAsync(categories);
            _context.SaveChanges();
        }

        public async Task AddBookTypes(List<BookType> bookTypes)
        {
            _context.BookTypes.AddRangeAsync(bookTypes);
            _context.SaveChanges();
        }

        public async Task AddBooks(List<Book> books)
        {
            _context.Books.AddRangeAsync(books);
            _context.SaveChanges();
        }
    }
}
