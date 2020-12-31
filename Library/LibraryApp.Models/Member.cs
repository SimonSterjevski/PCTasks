using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public MemberType MemberType { get; set; }
        public DateTime MembershipDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public List<BorowedBy> BorowCard { get; set; }
    }
}
