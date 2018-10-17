using NyTimesDisplay.Domain;
using NyTimesDisplay.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NyTimesDisplay
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            BooksDomain = new BooksDomain();

            CategoriesList.ItemsSource = Categories;
        }

        private BooksDomain BooksDomain { get; set; }

        public List<BookViewModel> List { get; set; }
        public BookViewModel Item { get; set; }
        public List<string> Categories = new List<string>()
        {
            "HARDCOVER FICTION",
            "HARDCOVER NONFICTION",
            "E-BOOK NONFICTION",
            "TRADE FICTION PAPERBACK",
            "PAPERBACK NONFICTION"
        };
        private async void LoadListAsync(object sender, ItemClickEventArgs e)
        {
            List = new List<BookViewModel>();
            var option = e.ClickedItem.ToString();
            List = await BooksDomain.LoadBooksByList(option);
            BooksList.ItemsSource = List;
        }
        private void SelectBook(object sender, ItemClickEventArgs e)
        {
            var option = e.ClickedItem;
            Item = (BookViewModel) option;
        }
    }
}
