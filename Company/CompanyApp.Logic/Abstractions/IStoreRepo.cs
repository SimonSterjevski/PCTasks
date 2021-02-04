using CompanyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Repository.Abstractions
{
    public interface IStoreRepo
    {
        List<Store> GetAll();
        Store GetOne(int id);
        void Update(Store store);
    }
}
