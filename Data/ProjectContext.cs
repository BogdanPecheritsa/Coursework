using CALLОМОЙСЬКИЙ.Models.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CALLОМОЙСЬКИЙ.Data;

public class ProjectContext : DbContext
{
        public DbSet<Calls> Calls { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {
        }
    }