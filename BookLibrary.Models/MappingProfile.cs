using AutoMapper;
using BookLibrary.Models.Dto;
using BookLibrary.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDto>()
                .ForMember(d => d.Type, src => src.MapFrom(m => m.BookType.Description))
                .ForMember(d => d.Authors, src => src.MapFrom(m => MapAuthors(m.Authors)))
                .ForMember(d => d.Categories, src => src.MapFrom(m => MapCategories(m.Categories)));
        }

        private List<string> MapCategories(List<BookCategory> categories)
        {
            return categories.Select(c => c.Description).ToList();
        }

        private List<string> MapAuthors(List<Author> authors)
        {
            return authors.Select(a => $"{a.FirstName} {a.LasName}").ToList();
        }
    }
}
