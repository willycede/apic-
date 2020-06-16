using ApiTest.Models;
using AutoMapper;


namespace Prueba.Profiles
{
    public class AlbumProfile : Profile
    {
        public AlbumProfile()
        {
            CreateMap<Album, AlbumDto>();
        }
    }
}