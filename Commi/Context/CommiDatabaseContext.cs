using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commi.Models;


namespace Commi.Context
{
    public class CommiDatabaseContext : DbContext
    {
        public CommiDatabaseContext(DbContextOptions<CommiDatabaseContext> options): base(options)
        {

        }
        public DbSet<Restaurant> Restaurant { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Plato> Platos{ get; set; }

    }
}
