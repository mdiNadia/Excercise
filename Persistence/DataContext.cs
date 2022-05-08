using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.Fluents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }



        public DbSet<ExcerciseEntity> ExcerciseEntities { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration<ExcerciseEntity>(new ExcerciseEntityFluent());
            


        }
    }

    
}
