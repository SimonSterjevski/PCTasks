﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Models
{
    public class BorowedBy
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}
