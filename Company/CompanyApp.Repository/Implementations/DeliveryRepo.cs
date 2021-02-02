using CompanyApp.DataAccess;
using CompanyApp.Domain.Models;
using CompanyApp.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyApp.Repository.Implementations
{
    public class DeliveryRepo: IDeliveryRepo
    {
        private CompanyAppDbContext _dbContext;
        public DeliveryRepo(CompanyAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<SuplyActivity> GetAll()
        {
            return _dbContext.Deliveries
                .ToList();
        }
        public void Add(SuplyActivity suplyActivity)
        {
            _dbContext.Deliveries.Add(suplyActivity);
            _dbContext.SaveChanges();
        }
    }
}
