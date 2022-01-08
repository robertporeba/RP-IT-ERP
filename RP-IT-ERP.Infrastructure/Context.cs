using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RP_IT_ERP.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Element> Elements { get; set; }
        public DbSet<Raport> Raports { get; set; }
        public DbSet<RaportType> RaportTypes { get; set; }
        public DbSet<Domain.Model.Task> Tasks { get; set; }
        public DbSet<Domain.Model.TaskStatus> TaskStatuses { get; set; }
        public DbSet<TaskType> TaskTypes { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
