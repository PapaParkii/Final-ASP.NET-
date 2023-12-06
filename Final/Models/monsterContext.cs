using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Final.Models
{
    public class monsterContext : DbContext
    {
        public monsterContext(DbContextOptions<monsterContext> options)
            : base(options)
        { }
        public DbSet<Monster> Monsters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Establish base database
            modelBuilder.Entity<Monster>().HasData(
                new Monster
                {
                    MonsterID = 1,
                    Name = "Spider",
                    Rating = 2
                },
                new Monster
                {
                    MonsterID = 2,
                    Name = "Bracken",
                    Rating = 5
                }
            );
        }
    }
}
