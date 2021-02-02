using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Domain.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Warehouse> Warehouses { get; set; }
        public List<Store> Stores { get; set; }
        public List<Product> Products { get; set; }

    }
}
