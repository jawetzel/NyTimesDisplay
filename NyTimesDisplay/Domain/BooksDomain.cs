using AutoMapper;
using NyTimesDisplay.DataAccess;
using NyTimesDisplay.Models;
using NyTimesDisplay.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyTimesDisplay.Domain
{
    public class BooksDomain
    {
        public async Task<List<BookViewModel>> LoadBooksByList(string list)
        {
            var bookList = await BooksApi.GetBooksByList(list);
            var parsedList = new List<BookViewModel>();
            foreach (var book in bookList)
            {
                var dto = Mapper.Map<BookViewModel>(book);
                parsedList.Add(dto);
            }
            return parsedList;
        }
    }
}
