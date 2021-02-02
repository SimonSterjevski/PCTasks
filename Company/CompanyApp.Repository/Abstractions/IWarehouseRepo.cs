using CompanyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Repository.Abstractions
{
    public interface IWarehouseRepo
    {
        List<Warehouse> GetAll();
        Warehouse GetOne(int id);
        void Update(Warehouse warehouse);
    }
}
