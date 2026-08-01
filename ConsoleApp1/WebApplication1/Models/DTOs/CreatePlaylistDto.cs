using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models.DTOs
{
    public class CreatePlaylistDto
    {
        [Required(ErrorMessage = "Playlist Title is required.")]
        public string Title { get; set; } = string.Empty;
        public List<CreateVideoDto> Videos { get; set; } = new();
    }
    
}