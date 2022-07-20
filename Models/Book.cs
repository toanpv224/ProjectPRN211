using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN211.Models
{
    public partial class Book
    {
        public Book()
        {
            BookAuthors = new HashSet<BookAuthor>();
        }

        public int Bid { get; set; }
        public string Title { get; set; }
        public bool IsFree { get; set; }

        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
