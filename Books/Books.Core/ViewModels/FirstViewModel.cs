using System.Collections.Generic;
using Books.Core.Services;
using Cirrious.MvvmCross.ViewModels;

namespace Books.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
        private string _searchTerm;

        public string SearchTerm
        {
            get { return _searchTerm; }
            set { _searchTerm = value; RaisePropertyChanged(() => SearchTerm); }
        }

        private MvxCommand _search;
        private IGetBooksService _booksService;
        private List<Item> _bookList;

        public FirstViewModel(IGetBooksService booksService)
        {
            _booksService = booksService;
        }

        public MvxCommand Search
        {
            get
            {
                _search = _search ?? new MvxCommand(DoSearch);
                return _search;
            }
        }

        private void DoSearch()
        {
            _booksService.StartSearchAsync(
                SearchTerm, 
                o =>
                    {
                        BookList = o.items;
                    }, 
                exception => {});
        }

        public List<Item> BookList
        {
            get { return _bookList; }
            set { _bookList = value; RaisePropertyChanged(() => BookList);}
        }
    }
}
