using MyProject.Core.UnitOfWorks;
using MyProject.DataAccess.Context;
using MyProject.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DataAccess.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        private IKullaniciRepository _kullaniciRepository;
        //private CategoryRepository _CategoryRepository;

        //public IProductRepository Products => _productRepository = _productRepository ?? new ProductRepository(_context);

        //public IKullaniciRepository kullanicis => _kullaniciRepository = _kullaniciRepository ?? new _kullaniciRepository(_context);

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
