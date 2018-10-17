using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyTimesDisplay.Models
{
    public class Book
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

        public List<Isbn> Isbns { get; set; }
        public List<BookDetail> Book_details { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
