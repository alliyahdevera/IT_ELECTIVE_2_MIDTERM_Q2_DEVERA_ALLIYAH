
using WebApplication1.Models.Entities;

namespace WebApplication1.Data
{
    public static class MockDatabase
    {
        public static List<Playlist> Playlists { get; set; } = new()
        {
            new Playlist
            {
                Title = "Favs Spider-Man",
                CreatorName = "System",
                Videos = new List<VideoItem>
                {
                    new VideoItem { YouTubeUrl = "(https://www.youtube.com/watch?v=ApXoWvfEYVU)", TrackNote = "Post Malone, Swae Lee - Sunflower"},
                    new VideoItem { YouTubeUrl = "(https://youtu.be/Y88LVU7MAe4?si=iOwPAGmgYYtHCGuP)", TrackNote = "Blackway & Black Caviar - What's Up Danger" }
                }
            }
        };
    }
}