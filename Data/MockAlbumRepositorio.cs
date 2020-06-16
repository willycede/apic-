using ApiTest.Models;

namespace ApiTest.Data
{
    public class MockAlbumRepositorio : IAlbum
    {
        public Album GetAlbum(int IdAlbum)
        {
            return new Album{Id=IdAlbum,NombreAlbum="PRUEBA", Calificacion=5, NombreAutor="AUTOR PRUEBA",FechaLanzamiento="2020-06-14", Precio=11.99};
        }
    }
}