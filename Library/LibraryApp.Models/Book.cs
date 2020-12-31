using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public bool IsAvaliable { get; set; }
        public Author Author { get; set; }
        public List<Edition> Edition { get; set; }
        public List<BorowedBy> BorowCard { get; set; }
    }
}
