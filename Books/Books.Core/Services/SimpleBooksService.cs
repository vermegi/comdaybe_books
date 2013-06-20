using System;

namespace Books.Core.Services
{
    public class SimpleBooksService : IGetBooksService
    {
        private readonly ISimpleRestService _restService;

        public SimpleBooksService(ISimpleRestService restService)
        {
            _restService = restService;
        }

        public void StartSearchAsync(string whatFor, Action<RootObject> success, Action<Exception> error)
        {
            var requestUrl = string.Format("https://www.googleapis.com/books/v1/volumes?q={0}", whatFor);
            _restService.MakeRequest(requestUrl, "GET", success, error);
        }
    }
}