using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using MediaHelper.Model;
using MediaHelper.Protobuf.grpc.Impl;
using Microsoft.AspNetCore.Mvc;
using SonarrSharp;

namespace MediaHelper.Blazor.Server.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SystemController : ControllerBase
    {
        [HttpPost("open/{episodeFileId}")]
        public async Task<ActionResult> Get(int episodeFileId, [FromQuery] int fromSeconds, [FromQuery] bool startInFullscreen)
        {
            var client = new SonarrClient("localhost", 8989, "2e8fcac32bf147608239cab343617485");
            var episodeFile = await client.EpisodeFile.GetEpisodeFile(episodeFileId);

            var mpcHcClient = new MediaPlayerClient("localhost", 50051);

            var startPosition = TimeSpan.FromSeconds(fromSeconds);

            var initRepsonse = await mpcHcClient.Init(@"C:\Program Files (x86)\MPC-HC\mpc-hc.exe");
            if (initRepsonse.IsError) return StatusCode(502);

            var isRunningResponse = await mpcHcClient.CheckIfMediaPlayerIsRunning();
            if (isRunningResponse.IsError) return StatusCode(502);
            
            if(isRunningResponse.Response.Value)
            {
                var stopResponse = await mpcHcClient.CloseMediaPlayer();
                if (stopResponse.IsError) return StatusCode(502);
            }
              
            var startResponse = await mpcHcClient.OpenMediaPlayer();
            if (startResponse.IsError) return StatusCode(502);
            
            await mpcHcClient.OpenFile(episodeFile.Path, startPosition, startInFullscreen);

            CurrentlyPlayingManager.EpisodeFile = episodeFile;

            return Ok();
        }

        [HttpGet("filesystem/{path}")]
        public ActionResult GetDirectoryAndFiles(string path)
        {
            if (path.EndsWith(".."))
                path = path.Remove(path.Length - 2, 2);

            var decodedPath = WebUtility.UrlDecode(path);

            var explorer = new FileExploror
            {
                Dirs = Directory.GetDirectories(decodedPath),
                Files = Directory.GetFiles(decodedPath)
            };

            return Ok(explorer);
        }

        [HttpGet("filesystem/drives")]
        public ActionResult GetLogicalDrive()
        {
            return Ok(Directory.GetLogicalDrives());
        }

        [HttpPut("mpchc/{path}")]
        public ActionResult UpdateMpcHcLocation(string path)
        {
            var decodedPath = WebUtility.UrlDecode(path);
            SettingsHelper.Save(new Settings {MpcHc = decodedPath});
            return Ok();
        }
    }
}