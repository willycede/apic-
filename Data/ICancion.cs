using System.Collections.Generic;
using ApiTest.Models;

namespace ApiTest.Data
{
    public interface ICancion{
        IEnumerable <Cancion> getCanciones(int IdCancion);
    }
}