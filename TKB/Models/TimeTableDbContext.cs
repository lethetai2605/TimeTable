using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TKB.Models
{
    public partial class TimeTableDbContext : DbContext
    {
        public TimeTableDbContext()
            : base("name=TimeTableDbContext")
        {
        }

        public virtual DbSet<TimeTable> TimeTables { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.PassWord)
                .IsUnicode(false);
        }
    }
}
