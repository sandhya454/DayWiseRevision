using AutoMapper;
using BookStoreAPI.Data;
using BookStoreAPI.Models;

namespace BookStoreAPI.Helper
{
    public class ApplicationMapper:Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Books, BookModel>().ReverseMap();
        }
    }
}
