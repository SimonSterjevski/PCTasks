using CompanyApp.DataAccess;
using CompanyApp.Domain.Models;
using CompanyApp.Repository.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyApp.Repository.Implementations
{
    public class WarehouseRepo : IWarehouseRepo
    {
        private CompanyAppDbContext _dbContext;
        public WarehouseRepo(CompanyAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Warehouse> GetAll()
        {
            return _dbContext.Warehouses
                .Include(x => x.Deliveries)
                .Include(x => x.WarehouseItems)
                .ToList();
        }
        public Warehouse GetOne(int id)
        {
            return _dbContext.Warehouses
                .Include(x => x.Deliveries)
                .Include(x => x.WarehouseItems)
                .FirstOrDefault(x => x.Id == id);
        }

        public void Update(Warehouse warehouse)
        {
            _dbContext.Warehouses.Update(warehouse);
            _dbContext.SaveChanges();
        }
    }
}
