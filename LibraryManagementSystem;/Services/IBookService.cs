using LibraryManagementSystem_.DTOs;

namespace LibraryManagementSystem_.Service;

public interface IBookService
{
    Task<IEnumerable<BookRespons>> GetAllAsync();
    Task<IEnumerable<BookRespons>> GetByIdAsync(int id);
    Task<IEnumerable< BookRespons>> AddAsync(AddBook request);
    Task UpdateAsync(BookRequest request);
    Task Delete(int id);


}
