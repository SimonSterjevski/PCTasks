using CompanyApp.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Helpers
{
    public static class DbConfig
    {
        public static void InjectSql(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<CompanyAppDbContext>(x =>
            x.UseSqlServer(connectionString));
        }
    }
}
