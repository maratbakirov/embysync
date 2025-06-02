using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace NetNewClient
{
    public class EmbyApiClient
    {
        private readonly HttpClient _httpClient;
        private string _apiKey;

        public EmbyApiClient(string baseUrl, string apiKey)
        {
            _httpClient = new HttpClient { BaseAddress = new System.Uri(baseUrl) };
            _apiKey = apiKey;
        }

        public string ApiKey
        {
            get => _apiKey;
            set => _apiKey = value;
        }

        private void AddApiKeyHeader()
        {
            if (_httpClient.DefaultRequestHeaders.Contains("X-Emby-Token"))
                _httpClient.DefaultRequestHeaders.Remove("X-Emby-Token");
            _httpClient.DefaultRequestHeaders.Add("X-Emby-Token", _apiKey);
        }

        public async Task<string> GetSystemInfoAsync()
        {
            AddApiKeyHeader();
            var response = await _httpClient.GetAsync("/System/Info").ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        }

        // Sessions APIs
        public async Task<string> GetSessionsAsync()
        {
            AddApiKeyHeader();
            var response = await _httpClient.GetAsync("/Sessions").ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        }

        public async Task<string> GetSessionCapabilitiesAsync()
        {
            AddApiKeyHeader();
            var response = await _httpClient.GetAsync("/Sessions/Capabilities").ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        }

        public async Task<string> GetSessionsPlayQueueAsync()
        {
            AddApiKeyHeader();
            var response = await _httpClient.GetAsync("/Sessions/PlayQueue").ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        }

        public async Task<string> PostSessionsLogoutAsync()
        {
            AddApiKeyHeader();
            var response = await _httpClient.PostAsync("/Sessions/Logout", null).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        }

        // Add more methods for other endpoints as needed, following the OpenAPI spec
    }
}
