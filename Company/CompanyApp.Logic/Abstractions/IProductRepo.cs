using CompanyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Repository.Abstractions
{
    public interface IProductRepo
    {
        List<Product> GetAll();
        Product GetOne(int id);
        void Update(Product product);
    }
}
