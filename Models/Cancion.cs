namespace ApiTest.Models
{
    public class Cancion{
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NombreArtista { get; set; }
        public string Time { get; set; }
        public int Popularity { get; set; }//1 al 10
        public double Precio { get; set; }
        public Album Album { get; set; }
    }
}