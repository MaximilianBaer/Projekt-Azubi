using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity;

namespace Domain.Acces
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("testDB")
        {

        }

        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Question> Questions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Survey>()
                .HasMany(u => u.Questions)
                .WithOptional(s => s.surveyID);
        }
    }
}


