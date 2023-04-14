using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<GameSystemEntity> GameSystems { get; set; }
        public DbSet<GenreEntity> Genres { get; set; }
        public DbSet<GameEntity> Games { get; set; }
    }
