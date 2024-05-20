using AutoMapper;
using Catalog.Dtos.BookDtos;
using Catalog.Dtos.CategoryDtos;
using Catalog.Dtos.LocationDtos;
using Catalog.Entities;

namespace Catalog.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            //Book
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<Book, CreateBookDto>().ReverseMap();
            CreateMap<Book, UpdateBookDto>().ReverseMap();

            //Category

            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();

            //Location
            CreateMap<Location, LocationDto>().ReverseMap();
            CreateMap<Location, CreateLocationDto>().ReverseMap();

        }
    }
}
