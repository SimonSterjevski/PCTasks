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
    public class StoreRepo : IStoreRepo
    {
        private CompanyAppDbContext _dbContext;
        public StoreRepo(CompanyAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Store> GetAll()
        {
            return _dbContext.Stores
                .Include(x => x.StoreItems)
                .ToList();
        }
        public Store GetOne(int id)
        {
            return _dbContext.Stores
                .Include(x => x.StoreItems)
                .FirstOrDefault(x => x.Id == id);
        }
        public void Update(Store store)
        {
            _dbContext.Stores.Update(store);
            _dbContext.SaveChanges();
        }
    }
}
