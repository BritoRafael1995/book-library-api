using AutoMapper;
using BookLibrary.DataStore.SQLServer.Interface;
using BookLibrary.Models;
using BookLibrary.Models.Dto;
using BookLibrary.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public async Task<List<BookDto>> Search(SearchFilter filter)
        {
            var books = await _bookRepository.Search(filter);

            return _mapper.Map<List<BookDto>>(books);
        }
    }
}
