using Employee.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Data
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<EmployeeClass> Employees { get; set; }
        public EmployeeDbContext()
        {

        }
        public EmployeeDbContext(DbContextOptions options)
       : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-3AOH9UNJ\SQLEXPRESS;Database=WebApiDB;Trusted_Connection=True");


        }
    }
}
