using LabFt.RequestDtos;
using LabFt.ResultDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LabFt
{
    public class SearchService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl;

        public SearchService(string accessToken)
        {
            _httpClient = new HttpClient();
            _apiBaseUrl = ConstantInfos.BaseUrl;
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("X-API-Key", ConstantInfos.XAPIKey);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
        }

        public async Task<List<ResultSearchDto>> GetDataAsync(RequestSearchDto requestData)
        {
            var requestUrl = $"{_apiBaseUrl}+{ConstantInfos.SearchEndPoint}";
            
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(requestData);

            //var requestContent = new FormUrlEncodedContent(requestData);

            var requestContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(requestUrl, requestContent);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Échec de l'obtention des données: {responseContent}");
            }

            var data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ResultSearchDto>>(responseContent);
            return data;
        }
    }
}
