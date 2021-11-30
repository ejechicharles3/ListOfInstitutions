using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListOfInstitutions.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions  options) : base(options)
        {}


        public DbSet<Country> Countries { get; set; }
        public DbSet<School> Schools { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Nigeria",
                    ShortName = "NG"
                },
                new Country
                {
                    Id = 2,
                    Name = "United State Of America",
                    ShortName = "USA"
                }, new Country
                {
                    Id = 3,
                    Name = "South Africa",
                    ShortName = "SA"
                }, new Country
                {
                    Id = 4,
                    Name = "Canada",
                    ShortName = "CA"
                }
                );

            builder.Entity<School>().HasData(
                new School
                {
                    Id = 1,
                    Name = "Open University",
                    Address = "FCT, Abuja",
                    CountryId = 1,
                    Rating = 4.5
                },
                new School
                {
                    Id = 2,
                    Name = "Massachusetts Institute of Technology",
                    Address = "Cambridge",
                    CountryId = 2,
                    Rating = 5.0
                },
                new School
                {
                    Id = 3,
                    Name = "University of South Africa",
                    Address = "Preller St, Muckleneuk, Pretoria, 0002, South Africa",
                    CountryId = 3,
                    Rating = 4.5
                }, 
                new School
                {
                    Id = 4,
                    Name = "University of Toronto",
                    Address = "Ontario, Canada",
                    CountryId = 4,
                    Rating = 5.4
                }
                );
        }


    }
}
