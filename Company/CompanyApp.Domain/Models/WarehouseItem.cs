namespace CompanyApp.Domain.Models
{
    public class WarehouseItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public int ProductId {get; set;}
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}