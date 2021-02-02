using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Domain.Models
{
    public class SuplyActivity
    {
        public Guid Id { get; set; }
        public DateTime SuplyDate { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public double Quantity { get; set; }
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }

    }
}
