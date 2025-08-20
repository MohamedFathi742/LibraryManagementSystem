using Data.Models;
using LibraryManagementSystem_.DTOs;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem_.Service;

public class BookService(ApplicationDbContext context) : IBookService
{
    private readonly ApplicationDbContext _context = context;

    public async Task<IEnumerable<Book>> GetAllAsync()
    {

       var book= await _context.Books.AsNoTracking().ToListAsync();
        return book;
    }
    public async Task<IEnumerable<Book>> PaginationAsync(int pageSize,int pageNum)
    {
        if (pageSize <= 0) pageSize = 10;

        if (pageNum <= 0) pageNum = 1;
       
        var totalCount = await _context.Books.CountAsync();

        var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
        var result=await _context.Books
            .Skip((pageNum - 1)*pageSize)
            .Take(pageSize)
            .ToListAsync();
            
        return result;
       
    }
    public async Task<Book> GetByIdAsync(int id)
    {
      var book =await _context.Books.FindAsync(id);
        return book!;
    }

    public async Task<Book> AddAsync(Book book)
    {
       var result= await _context.Books.AddAsync(book);
        await _context.SaveChangesAsync();
        return result.Entity;
    }
    public async Task UpdateAsync(Book book, int id )
    {
       var result= await _context.Books.FindAsync(id);
        if (result != null)
        {
         
            result.ISPN = book.ISPN;
            result.Auther = book.Auther;
            result.BookStatus = book.BookStatus;
            result.CreatedAt = book.CreatedAt;
            result.PuplishedYear = book.PuplishedYear;
                             
           

        }
        await _context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var result = await _context.Books.FindAsync(id);
     
         _context.Remove(result);
        _context.SaveChanges();
        
    }

   
}
