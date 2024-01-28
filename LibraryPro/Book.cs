using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPro
{
    public class Book
    {
        public Book(string title, string author, DateTime publishYear)
        {
            Title = title;
            Author = author;
            PublishYear = publishYear;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishYear { get; set; }


    }
}
