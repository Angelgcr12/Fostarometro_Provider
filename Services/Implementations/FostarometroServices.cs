using FostarometroAPI.Models.DTOs;
using FostarometroAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FostarometroAPI.Services.Implementations
{
    [Route("api/[controller]")]
    [ApiController]
    public class FostarometroServices : IFostarometroServices
    {
        [HttpGet("GetDefatultVideos")]
        public List<VideoInfoDTO> GetDefatultVideos()
        {
            // TODO: Implementar

            List<VideoInfoDTO> videosExample = new List<VideoInfoDTO>();
            videosExample.Add(new VideoInfoDTO { Id = Guid.NewGuid(), Name = "Video 1", Description = "Description 1" });
            videosExample.Add(new VideoInfoDTO { Id = Guid.NewGuid(), Name = "Video 2", Description = "Description 2" });
            videosExample.Add(new VideoInfoDTO { Id = Guid.NewGuid(), Name = "Video 3", Description = "Description 3" });
            return videosExample;
        }
    }
}
