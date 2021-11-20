using RubciX_Ps223020_DataAccess.Core.Interfaces.DbContext;
using RubciX_Ps223020_DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RubicX_Ps223020_DatAccess.DbContext
{
    public class RubicContext : IRubicContext
    {
        public DbSet<UserRto> Users { get; set; }
        public DbSet<UserRoleRto> UserRoles { get; set; }

        public void Dispose()
        {
            
        }

        public ValueTask DisposeAsync()
        {
            
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
        }
    }


}
