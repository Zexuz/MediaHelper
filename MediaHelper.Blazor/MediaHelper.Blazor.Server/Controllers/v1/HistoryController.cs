using System.Collections.Generic;
using MediaHelper.Backend;
using MediaHelper.Model;
using Microsoft.AspNetCore.Mvc;

namespace MediaHelper.Blazor.Server.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        [HttpGet("watched/last")]
        public ActionResult<MediaFile> LastWatched()
        {
            var mediaFileService = new MedieFileService();
            return Ok(mediaFileService.GetLastWatched());
        }
        
        [HttpGet("watched")]
        public ActionResult<List<MediaFile>> WatchHistory()
        {
            var mediaFileService = new MedieFileService();
            return Ok(mediaFileService.GetLatestWatched());
        }
    }
}