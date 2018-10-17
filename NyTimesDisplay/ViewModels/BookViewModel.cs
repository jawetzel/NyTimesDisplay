using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyTimesDisplay.ViewModels
{
    public class BookViewModel
    {
        public string List_name { get; set; }
        public string Display_name { get; set; }
        public string Bestsellers_date { get; set; }
        public int Rank { get; set; }
        public int Rank_last_week { get; set; }
        public int Weeks_on_list { get; set; }
        public int Asterisk { get; set; }
        public int Dagger { get; set; }
        public string Amazon_product_url { get; set; }

        public List<IsbnViewModel> Isbns { get; set; }
        public List<BookDetailViewModel> Book_details { get; set; }
        public List<ReviewViewModel> Reviews { get; set; }
    }
}
