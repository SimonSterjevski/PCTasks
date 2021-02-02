using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Domain.Models
{
    public class StoreItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
    }
}
