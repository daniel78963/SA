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
                .ForMember(dest => dest.FullName,
                opt => opt.MapFrom(Author => MapAuthorName(Author)));
            CreateMap<Author, AuthorWithBooksDTO>()
               .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => MapAuthorName(src)));
            CreateMap<AuthorCreationDTO, Author>();
            CreateMap<Author, AuthorPatchDTO>().ReverseMap();

            CreateMap<Book, BookDTO>();
            CreateMap<BookCreationDTO, Book>()
                .ForMember(dest => dest.Authors, opt => 
                opt.MapFrom(dto => dto.AuthorIds.Select(id => new AuthorBook { AuthorId = id })));
            //CreateMap<Book, BookWithAuthorDTO>()
            //    .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => MapAuthorName(src.Author!)));

            CreateMap<Comment, CommentDTO>();
            CreateMap<CommentCreationDTO, Comment>();
            CreateMap<Comment, CommentPatchDTO>().ReverseMap();
        }

        private string MapAuthorName(Author author) => $"{author.Names} {author.Surnames}";
    }
}
