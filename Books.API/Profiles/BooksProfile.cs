using AutoMapper;

namespace Books.API.Profiles
{
    public class BooksProfile : Profile
    {
        public BooksProfile()
        {
            CreateMap<Entities.Book, Models.Book>().ForMember(d => d.Author, o => o.MapFrom(s => $"{s.Author.FirstName} {s.Author.LastName}"));
        }
    }
}