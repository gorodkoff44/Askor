using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Страховая
{
    class ClientContext : System.Data.Entity.DbContext
    {
        public System.Data.Entity.DbSet<DBClient> DBClients { get; set; }
        public System.Data.Entity.DbSet<DBAvto> DBAvtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DBAvto.db");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
