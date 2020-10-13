using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Books.API.Services
{
    public interface IBookRepository
    {
        Task<Entities.Book> GetBookAsync(Guid id);

        Task<List<Entities.Book>> GetBooksAsync();
    }
}