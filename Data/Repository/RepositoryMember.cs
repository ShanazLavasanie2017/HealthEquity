using HealthEquity.Data.Entity;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
 

namespace HealthEquity.Data.Repository
{
    public class RepositoryMember : IRepositoryMember
    {
        private readonly HealthEquityDbContext _healthEquityDbContext;
        private readonly ILogger<RepositoryMember> _logger;
        public RepositoryMember(HealthEquityDbContext healthEquityDbContext, ILogger<RepositoryMember> logger)
        {
            _healthEquityDbContext = healthEquityDbContext;
            _logger = logger;
        }
        public void Add<TEntity>(TEntity entity) where TEntity : class
        {
            _logger.LogInformation($"Adding an object of type {entity.GetType()} to the context.");
            _healthEquityDbContext.Add(entity);
        }

        public async Task<Member> GetMemberById(int MemberId)
        {
            _logger.LogInformation($"Getting one Member");
            IQueryable<Member> query = _healthEquityDbContext.Members.Where(m => m.MemberId == MemberId);
            return await query.FirstOrDefaultAsync();
    
        }

        public async Task<bool> SaveChangesAsync()
        {

            _logger.LogInformation($"Attempting to save the changes to the context.");
            return (await _healthEquityDbContext.SaveChangesAsync()) > 0;

        }
    }
}
