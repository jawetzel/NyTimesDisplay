using AutoMapper;
using NyTimesDisplay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyTimesDisplay.ViewModels
{
    public class Mappings : Profile
    {
        public Mappings()
        {
            CreateMap<Book, BookViewModel>()
                .ForMember(dest => dest.Isbns, x => x.MapFrom(src => src.Isbns))
                .ForMember(dest => dest.Book_details, x => x.MapFrom(src => src.Book_details))
                .ForMember(dest => dest.Reviews, x => x.MapFrom(src => src.Reviews));

            CreateMap<BookDetail, BookDetailViewModel>();

            CreateMap<Isbn, IsbnViewModel>();

            CreateMap<Review, ReviewViewModel>();
        }
    }
}
