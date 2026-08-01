using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models.DTOs
{
    public class CreateVideoDto
    {
        public string YouTubeUrl { get; set; } = string.Empty;
        public string TrackNote { get; set; } = string.Empty;
    }
}
