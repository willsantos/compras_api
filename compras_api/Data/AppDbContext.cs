using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using compras_api.Models;
using Microsoft.EntityFrameworkCore;


namespace compras_api.Data
{
  public class AppDbContext : DbContext
  {
    protected readonly IConfiguration Configuration;

    public AppDbContext(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
      options.UseSqlServer(Configuration.GetConnectionString("ApiConnection"));
    }

    public DbSet<Item> Items { get; set; }
  }
}