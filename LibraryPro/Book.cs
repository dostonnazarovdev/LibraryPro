using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPro
{
    public class Book
    {
        public Book(int id,string title, string author, DateTime publishYear)
        {
            Id= id; 
            Title = title;
            Author = author;
            PublishYear = publishYear;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishYear { get; set; }
        public int count = 1;
        public void addBookCount(int count)
        {
            this.count += count;
        }

    }
}
