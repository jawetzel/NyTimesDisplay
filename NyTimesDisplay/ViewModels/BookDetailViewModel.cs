using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyTimesDisplay.ViewModels
{
    public class BookDetailViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Contributor { get; set; }
        public string Author { get; set; }
        public string Contributor_note { get; set; }
        public double Price { get; set; }
        public string Age_group { get; set; }
        public string Publisher { get; set; }
        public string Primary_isbn13 { get; set; }
        public string Primary_isbn10 { get; set; }
    }
}