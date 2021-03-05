using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using PrimeNG.TableFilter.Example.Infrastructure.Entities;

namespace PrimeNG.TableFilter.Example.Infrastructure
{
    public class EntityContext : DbContext
    {
        public EntityContext(DbContextOptions options) : base(options){  }
        
        public DbSet<WebBoardData> WebBoardDatas { get; set; }
    }
}