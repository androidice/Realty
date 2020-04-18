using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Realty.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, UserRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<BusinessInfo> BusinessInfo { get; set; }

        private IDbContextTransaction transaction;

        public async Task BeginTransactionAsync()
        {
            transaction = await Database.BeginTransactionAsync();
        }

        public async Task SaveAllChangesAsync()
        {
            try
            {
                await SaveChangesAsync();
                transaction.Commit();
            }
            finally
            {
                transaction.Dispose();
            }
        }


        public void RollbackTransaction()
        {
            transaction.Rollback();
            transaction.Dispose();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            /*configure relationships*/

            /*configure relationships*/

            base.OnModelCreating(builder);
        }
    }
}
