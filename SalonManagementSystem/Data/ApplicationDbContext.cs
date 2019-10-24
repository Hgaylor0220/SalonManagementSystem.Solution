
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SalonManagementSystem.Models;

namespace SalonManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public virtual DbSet<Stylist> Stylists { get; set; }
        public DbSet<Client> Clients { get; set; }
       

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}