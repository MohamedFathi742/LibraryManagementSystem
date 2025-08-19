using Data.Models;
using LibraryManagementSystem_.DTOs;

namespace LibraryManagementSystem_.Service;

public interface IBookService
{
    Task<IEnumerable<Book>> GetAllAsync();
    Task<Book> GetByIdAsync(int id);
    Task< Book> AddAsync(Book book);
    Task UpdateAsync(Book book,int id);
    Task Delete(int id);


}
