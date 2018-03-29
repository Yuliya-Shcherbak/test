using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Test.DataAccess.Entities;

namespace Test.DataAccess.EFContext
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<ClientModel> Clients { get; set; }
        public DbSet<TaskModel> Tasks { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TestAppDB;Trusted_Connection=True;");
        //}
    }
}
