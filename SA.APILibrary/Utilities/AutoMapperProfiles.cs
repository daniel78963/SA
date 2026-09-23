using AutoMapper;
using SA.APILibrary.DTOs;
using SA.APILibrary.Entities;

namespace SA.APILibrary.Utilities
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Author, AuthorDTO>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.Names} {src.Surnames}"));
            CreateMap<AuthorCreationDTO, Author>();

            CreateMap<Book, BookDTO>();
            CreateMap<BookCreationDTO, Book>();
        }
    } 
}
