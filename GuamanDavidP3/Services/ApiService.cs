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


        public async Task<bool> DeleteProducto(int Id)
        {
            var response = await _httpClient.DeleteAsync($"/api/Producto/{Id}");
            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return true;
            }
            return false;
        }

        public async Task<Tarea> GetTarea(int Id)
        {
            var response = await _httpClient.GetAsync($"/api/Tarea/{Id}");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                Tarea tarea = JsonConvert.DeserializeObject<Tarea>(json_response);
                return tarea;
            }
            return new Tarea();
        }

        public async Task<List<Tarea>> GetTareas()
        {
            var response = await _httpClient.GetAsync("/api/Tarea");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                List<Tarea> productos = JsonConvert.DeserializeObject<List<Tarea>>(json_response);
                return productos;
            }
            return new List<Tarea>();

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

        public async Task<Tarea> PutProducto(int Id, Tarea tarea)
        {
            var content = new StringContent(JsonConvert.SerializeObject(tarea), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"/api/Tarea/{Id}", content);
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
