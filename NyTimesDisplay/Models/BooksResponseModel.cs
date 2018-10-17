using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyTimesDisplay.Models
{
    public class BooksResponseModel
    {
        public string Status { get; set; }
        public string Copyright { get; set; }
        public int Num_results { get; set; }
        public DateTime Last_modified { get; set; }

        public List<Book> Results { get; set; }

    }
}
