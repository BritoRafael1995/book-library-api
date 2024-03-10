using BookLibrary.Models;
using BookLibrary.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.DataStore.SQLServer.Interface
{
    public interface IBookRepository
    {
        Task<List<Book>> Search(SearchFilter filter);
        Task AddAuthors(List<Author> authors);
        Task AddCategories(List<BookCategory> categories);
        Task AddBookTypes(List<BookType> bookTypes);
        Task AddBooks(List<Book> books);
    }
}
