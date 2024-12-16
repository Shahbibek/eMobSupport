
using eMobSupport.Models;

namespace eMobSupport.IServices
{
    public interface IApiService
    {
        Task<VideoSearchResult> SearchVideos(string searchQuery, string nextPageToken = "");
    }
}
