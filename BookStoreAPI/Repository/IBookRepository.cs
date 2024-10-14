using Azure;
using BookStoreAPI.Models;
using JsonPatch = Microsoft.AspNetCore.JsonPatch;

namespace BookStoreAPI.Repository
{
    public interface IBookRepository
    {
        Task<List<BookModel>> GetAllBooksAsync();
        Task<BookModel> GetBookByIdAsync(int bookId);
        Task<int> AddBookAsync(BookModel bookModel);
        Task UpdateBookAsync(int bookId, BookModel bookModel);
        Task UpdateBookPatchAsync(int bookId, JsonPatch.JsonPatchDocument bookModel);
        Task DeleteBookAsync(int bookId);
    }
}