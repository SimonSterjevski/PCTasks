using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Models
{
    public class Edition
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int BookId { get; set; }
        public Book Book {get; set;}
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        
    }
}
