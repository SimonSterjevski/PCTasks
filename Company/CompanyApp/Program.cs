using CompanyApp.DataAccess;
using CompanyApp.Logic;
using Microsoft.EntityFrameworkCore;
using System;

namespace CompanyApp
{
    class Program
    {
        private static CompanyAppDbContext _context = new CompanyAppDbContext();
        private static SuplyImplementation _suplyImplementation = new SuplyImplementation();
        static void Main(string[] args)
        {
            _context.SaveChanges();
            _suplyImplementation.AddAndRemoveStock(new Logic.ViewModels.Demand());
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
