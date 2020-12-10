using Microsoft.EntityFrameworkCore;
using MyProject.Entities.Tables;

namespace MyProject.DataAccess.Context
{
    public partial class AppDbContext
    {
        public DbSet<Kullanici> Kullanicis { get; set; }
    }
}
