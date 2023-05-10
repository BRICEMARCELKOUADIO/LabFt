using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace LabFt
{
    public class TokenRequester
    {
        private readonly HttpClient _httpClient;
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly string _scope;
        private readonly string _tokenEndpoint;

        public TokenRequester(string tokenEndpoint, string clientId, string clientSecret, string scope)
        {
            _httpClient = new HttpClient();
            _clientId = clientId;
            _clientSecret = clientSecret;
            _scope = scope;
            _tokenEndpoint = tokenEndpoint;
        }

        public async Task<string> GetAccessTokenAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Post, _tokenEndpoint);
            var authHeader = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{_clientId}:{_clientSecret}")));
            request.Headers.Authorization = authHeader;
            request.Content = new FormUrlEncodedContent(new[]
            {
            new KeyValuePair<string, string>("grant_type", "client_credentials"),
            new KeyValuePair<string, string>("scope", _scope)
        });

            var response = await _httpClient.SendAsync(request);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Failed to get access token: {responseContent}");
            }

            dynamic token = Newtonsoft.Json.JsonConvert.DeserializeObject(responseContent);
            return token.access_token;
        }
    }
}