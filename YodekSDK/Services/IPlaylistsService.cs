using YodeckSDK.Models;

namespace YodeckSDK.Services;

public interface IPlaylistsService
{
    Task<IEnumerable<Playlist>> GetAllPlaylistsAsync();
    Task<Playlist> GetPlaylistAsync(string playlistId);
    Task<bool> DeletePlaylistAsync(string playlistId);
}