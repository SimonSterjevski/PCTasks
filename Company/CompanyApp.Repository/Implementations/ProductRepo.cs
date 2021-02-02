using CompanyApp.DataAccess;
using CompanyApp.Domain.Models;
using CompanyApp.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyApp.Repository.Implementations
{
    public class ProductRepo : IProductRepo
    {
        private CompanyAppDbContext _dbContext;
        public ProductRepo(CompanyAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Product> GetAll()
        {
            return _dbContext.Products.ToList();
        }
        public Product GetOne(int id)
        {
            return _dbContext.Products.FirstOrDefault(x => x.Id == id);
        }
        public void Update(Product product)
        {
            _dbContext.Products.Update(product);
            _dbContext.SaveChanges();
        }
    }
}
