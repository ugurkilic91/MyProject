using MyProject.Core.Repositories;
using MyProject.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DataAccess.Interfaces
{

    public interface IKullaniciRepository : IRepository<Kullanici>
    {
        Task<Kullanici> KullaniciByIdAsync(int categoryId);
    }
}
