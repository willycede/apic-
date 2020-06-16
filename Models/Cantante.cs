using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Models
{
    public class Cantante
    {
        public int Id { get; set; }
        public string Nombre{ get; set; }

        public List<Album> Albums { get; set; }

    }
}
