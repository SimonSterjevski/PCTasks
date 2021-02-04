using CompanyApp.Domain.Models;
using CompanyApp.Logic.ViewModels;
using CompanyApp.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyApp.Logic
{
    public class SuplyImplentation: ISuply
    {
        private IStoreRepo _storeRepo;
        private IWarehouseRepo _warehouseRepo;
        private IDeliveryRepo _deliveryRepo;
        private IProductRepo _productRepo;

        public SuplyImplentation(IStoreRepo storeRepo, IWarehouseRepo warehouseRepo, IDeliveryRepo deliveryRepo, IProductRepo productRepo)
        {
            _storeRepo = storeRepo;
            _warehouseRepo = warehouseRepo;
            _deliveryRepo = deliveryRepo;
            _productRepo = productRepo;
        }
        public void CreateAndAddSuply(Demand demand)
        {
            List<Warehouse> warehouses = _warehouseRepo.GetAll();     
            Store store = _storeRepo.GetOne(demand.StoreId);
            Product product = _productRepo.GetOne(demand.ProductId);

            while (demand.Quantity > 0)
            {
                var warehouse = warehouses.FirstOrDefault(x => x.WarehouseItems.Any(x => x.ProductId == demand.ProductId && x.Quantity > 0));
                var warehouseItem = warehouse.WarehouseItems.FirstOrDefault(x => x.ProductId == demand.ProductId);
                var quantity = demand.Quantity;
                
                if (warehouseItem.Quantity < demand.Quantity)
                {
                    quantity = warehouseItem.Quantity;
                    demand.Quantity -= warehouseItem.Quantity;
                } else
                {
                    demand.Quantity -= demand.Quantity;
                }

                var newSuply = new SuplyActivity
                {
                    Id = new Guid(),
                    SuplyDate = DateTime.UtcNow,
                    ProductId = demand.ProductId,
                    StoreId = demand.StoreId,
                    WarehouseId = warehouse.Id,
                    Quantity = quantity
                };

                AddAndRemoveStock(warehouse ,store, product, quantity);

                _deliveryRepo.Add(newSuply);   

                warehouse.Deliveries.Add(newSuply);
                _warehouseRepo.Update(warehouse);
            }
           
        }

        private void AddAndRemoveStock(Warehouse warehouse, Store store, Product product, double quantity)
        {
            store.StoreItems.Where(x => x.ProductId == product.Id).ToList().ForEach(x => x.Quantity += quantity);
            warehouse.WarehouseItems.Where(x => x.ProductId == product.Id).ToList().ForEach(x => x.Quantity -= quantity);
            product.Quantity -= quantity;

            _storeRepo.Update(store);
            _warehouseRepo.Update(warehouse);
            _productRepo.Update(product);
        }

    }
}
