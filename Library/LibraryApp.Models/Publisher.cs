using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Edition> Edition { get; set; }
    }
}
