using Microsoft.EntityFrameworkCore;
using MyProject.Core.Repositories;
using MyProject.DataAccess.Context;
using MyProject.DataAccess.Interfaces;
using MyProject.Entities.Tables;
using System.Threading.Tasks;

namespace MyProject.DataAccess.Repository
{
    public class KullaniciRepository : Repository<Kullanici>, IKullaniciRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public KullaniciRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Kullanici> KullaniciByIdAsync(int categoryId)
        {
            return await _appDbContext.Kullanicis.Include(x => x.ID).SingleOrDefaultAsync(x => x.ID == categoryId);
        }
    }
}
