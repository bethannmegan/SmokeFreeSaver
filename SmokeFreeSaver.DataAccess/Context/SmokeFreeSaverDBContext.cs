using SmokeFreeSaver.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace SmokeFreeSaver.DataAccess.Context
{
    public partial class SmokeFreeSaverDBContext : DbContext
    {
        public SmokeFreeSaverDBContext(DbContextOptions options) : base(options)
        {

        }

        protected SmokeFreeSaverDBContext()
        {

        }

        public virtual DbSet<SmokeFreeSaverModel> SmokeFreeSaverModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SmokeFreeSaverModel>(
                entity =>
                {
                    entity.HasKey(e => e.ID);
                    entity.Property(e => e.ID);
                    entity.Property(e => e.CurrentDate);
                    entity.Property(e => e.EndDate);
                    entity.Property(e => e.NumberOfCigarettesSmoked);
                    entity.Property(e => e.NumberOfPacksBought);
                }
                );

            
            OnModelCreatingPartial(modelBuilder);

        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
