using CompanyApp.Domain.Models;
using CompanyApp.Logic.ViewModels;
using CompanyApp.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyApp.Logic
{
    public class SuplyImplementation: ISuplyImplementation
    {
        private IStoreRepo _storeRepo;
        private IWarehouseRepo _warehouseRepo;
        private IDeliveryRepo _deliveryRepo;
        private IProductRepo _productRepo;

        public SuplyImplementation(IStoreRepo storeRepo, IWarehouseRepo warehouseRepo, IDeliveryRepo deliveryRepo, IProductRepo productRepo)
        {
            _storeRepo = storeRepo;
            _warehouseRepo = warehouseRepo;
            _deliveryRepo = deliveryRepo;
            _productRepo = productRepo;
        }
        public void CreateAndAddSuply(Demand demand)
        {
            //List<Warehouse> warehouses = _warehouseRepo.GetAll();     // can they stay here ????
            //List<Store> stores = _storeRepo.GetAll();

            while (demand.Quantity > 0)
            {
                List<Warehouse> warehouses = _warehouseRepo.GetAll();
                List<Store> stores = _storeRepo.GetAll();

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

                AddAndRemoveStock(newSuply);

                _deliveryRepo.Add(newSuply);   

                warehouse.Deliveries.Add(newSuply);
                _warehouseRepo.Update(warehouse);
            }
           
        }

        private void AddAndRemoveStock(SuplyActivity newSuply)
        {
            var store = _storeRepo.GetOne(newSuply.StoreId);
            var warehouse = _warehouseRepo.GetOne(newSuply.WarehouseId);
            var product = _productRepo.GetOne(newSuply.ProductId);

            store.StoreItems.Where(x => x.ProductId == newSuply.ProductId).ToList().ForEach(x => x.Quantity += newSuply.Quantity);
            warehouse.WarehouseItems.Where(x => x.ProductId == newSuply.ProductId).ToList().ForEach(x => x.Quantity -= newSuply.Quantity);
            product.Quantity -= newSuply.Quantity;

            _storeRepo.Update(store);
            _warehouseRepo.Update(warehouse);
            _productRepo.Update(product);
        }

    }
}
