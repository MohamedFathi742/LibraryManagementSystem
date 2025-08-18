using Data.Models;
using LibraryManagementSystem_.DTOs;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem_.Service;

public class BookService(ApplicationDbContext context) : IBookService
{
    private readonly ApplicationDbContext _context = context;

    public async Task<IEnumerable<BookRespons>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<BookRespons>> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<BookRespons>> AddAsync(AddBook request)
    {
        throw new NotImplementedException();
    }
    public Task UpdateAsync(BookRequest request)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

 


  
}
