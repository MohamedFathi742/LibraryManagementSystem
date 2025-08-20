using Data.Models;
using LibraryManagementSystem_.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace LibraryManagementSystem_.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BooksController(IBookService bookService) : ControllerBase
{
    private readonly IBookService _bookService = bookService;


    [HttpGet]
    public async Task< IActionResult> GetAll()
    {
        return Ok(await _bookService.GetAllAsync());
    
    
    
    }
    [HttpGet("pagination")]
    public async Task< IActionResult> Pagination([FromQuery] int pageSize, [FromQuery]int pageNum)
    {
        var result=await _bookService.PaginationAsync(pageSize,pageNum);

        return Ok(result);
    
    
    
    }

    [HttpGet("{id}")]
    public async Task< IActionResult> GetById(int id)
    {
        return Ok(await _bookService.GetByIdAsync( id));
    
    }

    [HttpPost]
    public async Task<IActionResult> AddBook(Book book)
    {
     var result= await _bookService.AddAsync(book);
        return Ok(result);
    
    
    }
    [HttpPut]
    public async Task<IActionResult> UpdateBook(int id, Book book)
    {
     await _bookService.UpdateAsync(book,id);
        return NoContent();
    
    
    }
    [HttpDelete]
    public async Task<IActionResult> DeleteBook(int id)
    {
     await _bookService.Delete(id);
        return NoContent();
    
    
    }

    


}
