using HealthEquity.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthEquity.Data.Repository
{
    public interface IRepositoryMember
    {
        void Add<TEntity>(TEntity entity) where TEntity : class;
        Task<Member> GetMemberById(int MemberId);
        Task<bool> SaveChangesAsync();
    }
}
