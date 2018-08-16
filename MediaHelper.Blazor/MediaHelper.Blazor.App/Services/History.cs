using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MediaHelper.Model;
using Microsoft.AspNetCore.Blazor;

namespace MediaHelper.Blazor.App.Services
{
    public class History
    {
        private readonly HttpClient _client;

        public History(HttpClient client)
        {
            _client = client;
        }

        public async Task<SeriesFile> LastWatched()
        {
            return await _client.GetJsonAsync<SeriesFile>($"history/watched/last");
        }

        public async Task<SeriesFile> LastWatched(int seriesId)
        {
            return await _client.GetJsonAsync<SeriesFile>($"history/watched/last/{seriesId}");
        }

        public async Task<List<SeriesFile>> WatchHistory()
        {
            return await _client.GetJsonAsync<List<SeriesFile>>($"history/watched");
        }
        
    }
}