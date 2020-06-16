using System.Collections.Generic;
using System.Linq;
using ApiTest.Context;
using ApiTest.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTest.Data
{
    public class SqlAlbum : IAlbum
    {
        private readonly AlbumContext _context;

        public SqlAlbum(AlbumContext context)
        {
            _context = context;
        }

        public Album GetAlbum(int idAlbum)
        {
            return _context.Albums
            .Include(model => model.Cantante)
            .Include(model => model.Canciones)
            .FirstOrDefault(model => model.Id == idAlbum);

        }


    }
}