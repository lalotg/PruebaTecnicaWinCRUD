using PruebaCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCRUD.View.ClientHelper
{
    public class DatoClientHelper : IDisposable
    {
        string baseAddress;
        HttpMessageHandler handler;

        public DatoClientHelper()
        {
            baseAddress = "https://localhost:44322";
        }

        public async Task<List<Sexo>> Sexos()
        {
            handler = new HttpClientHandler();
            var model = new List<Sexo>();
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue
                    ("application/json"));
                var Response = await client.GetAsync($"{baseAddress}/api/Sexo");
                if (Response.IsSuccessStatusCode)
                {
                    model = await Response.Content.ReadAsAsync<List<Sexo>>();
                }
            }
            return model;
        }

        public async Task<List<Dato>> Datos()
        {
            handler = new HttpClientHandler();
            var model = new List<Dato>();
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue
                    ("application/json"));
                var Response = await client.GetAsync($"{baseAddress}/api/Dato");
                if (Response.IsSuccessStatusCode)
                {
                    model = await Response.Content.ReadAsAsync<List<Dato>>();
                }
            }
            return model;
        }

        public async Task<Dato> AddDatos(Dato model)
        {
            handler = new HttpClientHandler();
            var res = new Dato();
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue
                    ("application/json"));
                var Response = await client.PostAsJsonAsync($"{baseAddress}/api/Dato", model);
                if (Response.IsSuccessStatusCode)
                {
                    res = await Response.Content.ReadAsAsync<Dato>();
                }
            }
            return res;
        }


        public async Task<int> UpDato(Dato model)
        {
            handler = new HttpClientHandler();
            int res = 0;
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue
                    ("application/json"));
                var Response = await client.PutAsJsonAsync($"{baseAddress}/api/Dato", model);
                if (Response.IsSuccessStatusCode)
                {
                    res = await Response.Content.ReadAsAsync<int>();
                }
            }
            return res;
        }

        public async Task<int> DelDato(int id)
        {
            handler = new HttpClientHandler();
            int res = 0;
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue
                    ("application/json"));
                var Response = await client.DeleteAsync($"{baseAddress}/api/Dato/{id}");
                if (Response.IsSuccessStatusCode)
                {
                    res = await Response.Content.ReadAsAsync<int>();
                }
            }
            return res;
        }

        public void Dispose()
        {
            handler.Dispose();
        }
    }
}
