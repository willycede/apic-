using ApiTest.Data;
using ApiTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiTest.Controllers
{
    using AutoMapper;
    [Route("api/albums")]
    [ApiController]
    public class AlbumController:ControllerBase{
        private ILog loggerC;
        private readonly IAlbum _album;

        private readonly IMapper _mapper;

        public AlbumController(IAlbum album, ILog logger, IMapper mapper)
        {
            _album = album;
            loggerC = logger;
            _mapper=mapper;


        }
        [HttpGet("{id}")]
        public ActionResult<AlbumDto> GetAlbumById(int id){

            loggerC.Information("Information is logged");
            loggerC.Debug("Debug log is logged");
            var album = _album.GetAlbum(id);
            if (album ==null) 
            {
                 loggerC.Warning("Warning is logged");
                 loggerC.Error("Not found");
                return NotFound();
            }
            return Ok(_mapper.Map<AlbumDto>(album));  
        }
    }
}