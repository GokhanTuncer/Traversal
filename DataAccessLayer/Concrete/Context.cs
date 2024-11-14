using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-EOIN7IK\\SQLEXPRESS;database=TraversalDB;Integrated Security = True;TrustServerCertificate=true;");
           
        }

        public DbSet<About> About { get; set; }
        public DbSet<About2> About2 { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Destination> Destination { get; set; }
        public DbSet<Feature> Feature { get; set; }
        public DbSet<Feature2> Feature2 { get; set; }
        public DbSet<Guide> Guide { get; set; }
        public DbSet<Newsletter> Newsletter { get; set; }
        public DbSet<SubAbout> SubAbout { get; set; }
        public DbSet<Testimonial> Testimonial { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}
