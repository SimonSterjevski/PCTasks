using CompanyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Logic.ViewModels
{
    public class Demand
    {
        private double _quantity;
        public int Id { get; set; }
        public DateTime SuplyDate { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public double Quantity
        {
            get
            {
                if(_quantity > Product.Quantity)
                {
                    throw new Exception("Not enough supply");
                } else
                {
                    return _quantity;
                }
            }
            set
            {
                _quantity = value;
            }
        }
        public int StoreId { get; set; }
        public Store Store { get; set; }
        
        }
}
