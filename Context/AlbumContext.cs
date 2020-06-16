using ApiTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Context
{
    public class AlbumContext : DbContext
    {
        public AlbumContext(DbContextOptions<AlbumContext> opt) : base(opt)
        {

        }
        public DbSet<Cantante> Cantante { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Cancion> Cancion { get; set; }


    }
}
