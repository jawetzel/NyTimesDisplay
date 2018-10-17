using Newtonsoft.Json;
using NyTimesDisplay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyTimesDisplay.DataAccess
{
    public static class BooksApi
    {
        public static async Task<BooksResponseModel> GetBooksByList(string list)
        {
            Windows.Web.Http.HttpClient httpClient = new Windows.Web.Http.HttpClient();

            Uri requestUri = new Uri("https://api.nytimes.com/svc/books/v3/lists.json?api-key=3a4cca2238e24d139d271ad5d226637e&=&list=" + list.Replace(" ", "%20"));

            Windows.Web.Http.HttpResponseMessage httpResponse = new Windows.Web.Http.HttpResponseMessage();
            string httpResponseBody = "";

            try
            {
                httpResponse = await httpClient.GetAsync(requestUri);
                httpResponse.EnsureSuccessStatusCode();
                httpResponseBody = await httpResponse.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<BooksResponseModel>(httpResponseBody);
            
                return result.Status == "OK" ? result : null;
            }
            catch (Exception ex)
            {
                httpResponseBody = "Error: " + ex.HResult.ToString("X") + " Message: " + ex.Message;
                return null;
            }
        }
    }
}
