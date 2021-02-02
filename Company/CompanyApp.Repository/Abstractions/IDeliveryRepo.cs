using CompanyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Repository.Abstractions
{
    public interface IDeliveryRepo
    {
        List<SuplyActivity> GetAll();
        void Add(SuplyActivity suplyActivity);
    }
}
