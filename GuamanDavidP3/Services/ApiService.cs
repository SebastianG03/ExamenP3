using GuamanDavidP3.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GuamanDavidP3.Services
{
    public class APIService
    {
        public static string _baseUrl;
        public HttpClient _httpClient;

        public APIService()
        {

            _baseUrl = "http://10.0.2.2:5129/";
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_baseUrl);
        }


        public async Task<Tarea> PostTarea(Tarea tarea)
        {
            var content = new StringContent(JsonConvert.SerializeObject(tarea), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("/api/Tarea/", content);
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                Tarea tarea2 = JsonConvert.DeserializeObject<Tarea>(json_response);
                return tarea2;
            }
            return new Tarea();
        }

        public async Task<Tarea> BuscarTarea(string nombre, string estado)
        {
            var response = await _httpClient.GetAsync($"/api/Tarea/{nombre}/{estado}");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                Tarea tarea2 = JsonConvert.DeserializeObject<Tarea>(json_response);
                return tarea2;
            }
            return new Tarea();
        }
    }
}
