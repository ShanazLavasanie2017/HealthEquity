using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthEquity.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace HealthEquity.Data
{
    public class HealthEquityDbContext : DbContext
    {
        public HealthEquityDbContext(DbContextOptions option) : base(option)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            CreateSeedMember(builder);
        }

        public DbSet<Member> Members { get; set; }
        private void CreateSeedMember(ModelBuilder builder)
        {
            builder.Entity<Member>().HasData(
                new Member
                {
                    MemberId = 1,
                    FirstName = "George",
                    LastName = "Clooney",
                    PhoneNumber = "801-444-5555",
                    Email = "GeorgeC@Yahoo.com"
                },
                new
                {
                    MemberId = 2,
                    FirstName = "Robert",
                    LastName = "Redford",
                    PhoneNumber = "801-333-5655",
                    Email = "RobertR@Yahoo.com"
                },
                new
                {
                    MemberId = 3,
                    FirstName = "Albert",
                    LastName = "Einstein",
                    PhoneNumber = "801-663-5655",
                    Email = "AlbertE@Yahoo.com"
                });
        }
    }
}
