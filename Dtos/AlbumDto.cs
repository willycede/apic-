using System.Collections.Generic;

namespace ApiTest.Models
{
    public class AlbumDto{
        public int Id { get; set; }
        public string NombreAlbum { get; set; }
        public int Calificacion { get; set; }//1 al 5
        public string NombreAutor { get; set; }
        public string FechaLanzamiento { get; set; }
        public double Precio { get; set; }

        public Cantante Cantante { get; set; }
        public List<Cancion> Canciones { get; set; }
    }
}
