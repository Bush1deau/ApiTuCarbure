using ApiTuCarbure.EntityLayer;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ApiTuCarbure.Models
{
    public class TuCarburesContext : DbContext
    {
        public TuCarburesContext(DbContextOptions<TuCarburesContext> options) : base(options)
        {

        }

        public DbSet<Station> Stations { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<Statement> Statements { get; set; }

    }
}