using System;

namespace Books.Core.Services
{
    public interface IGetBooksService
    {
        void StartSearchAsync(string whatFor, Action<RootObject> success, Action<Exception> error);
    }
}