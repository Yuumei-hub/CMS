using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-9SC1960C\\SQLEXPRESS;database=WebProjeDB;integrated security=true");
        }
        public DbSet<User>? Users { get; set; }
        public DbSet<About>? Abouts { get; set; }
        public DbSet<Slider>? Sliders { get; set; }
        public DbSet<Game>? Games { get; set; }
        public DbSet<Testimonial>? Testimonials { get; set; }
        public DbSet<Service>? Services { get; set; }
    }
}
