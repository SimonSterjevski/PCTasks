using CompanyApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CompanyApp.Domain.Models
{
    public class Store
    {
        public int Id { get; set; }
        public double Size { get; set; }
        public string Location { get; set; }
        public string Manager { get; set; }
        public StoreType StoreType { get; set; }
        public List<StoreItem> StoreItems { get; set; }
    }
}
