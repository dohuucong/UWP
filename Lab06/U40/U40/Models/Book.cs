using System.Collections.Generic;
using Windows.ApplicationModel.Store.Preview.InstallControl;

namespace U40.Models
{
    public class Book
    {
        public int BookId { 
            get;
            set;
                }
        public string Title { get; set; }
            public string Author { get; set; }
            public string ConverImg { get; set; }
    }
    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();
            books.Add(new Book {BookId = 1, Title = "Test", Author = "Nothing", ConverImg = "https://cdn.cloudflare.steamstatic.com/steam/apps/1014460/header.jpg?t=1552722824"});
            return books;
        }
    }
}