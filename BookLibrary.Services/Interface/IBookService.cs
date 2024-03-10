using BookLibrary.Models;
using BookLibrary.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Services.Interface
{
    public interface IBookService
    {
        Task<List<BookDto>> Search(SearchFilter filter);
    }
}
