using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CompanyApp.Domain.Models
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public List<WarehouseItem> WarehouseItems { get; set; }

        public List<SuplyActivity> Deliveries { get; set; }
    }
}
