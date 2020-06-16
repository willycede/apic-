using System.Collections.Generic;
using ApiTest.Models;

namespace ApiTest.Data
{
    public interface IAlbum{
        Album GetAlbum(int IdAlbum);
    }
}