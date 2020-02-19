using PruebaCRUD.CPMX.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCRUD.View.ClientHelper
{
    public class CPMXClientHelper : IDisposable
    {
        string baseAddress;
        HttpMessageHandler handler;

        public CPMXClientHelper()
        {
            baseAddress = "https://localhost:44322";
        }

        public async Task<IEnumerable<Asentamiento>> AsentamientosPorCP(string cp)
        {
            handler = new HttpClientHandler();
            var model = new List<Asentamiento>();
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue
                    ("application/json"));
                var Response = await client.GetAsync($"{baseAddress}/api/AsentamientosMX?cp={cp}");
                if (Response.IsSuccessStatusCode)
                {
                    model = await Response.Content.ReadAsAsync<List<Asentamiento>>();
                }
            }
            return model;
        }

        public async Task<Estado> EstadoPorId(int id)
        {
            handler = new HttpClientHandler();
            var model = new Estado();
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue
                    ("application/json"));
                var Response = await client.GetAsync($"{baseAddress}/api/EstadosMX/{id}");
                if (Response.IsSuccessStatusCode)
                {
                    model = await Response.Content.ReadAsAsync<Estado>();
                }
            }
            return model;
        }


        public async Task<Municipio> EstadoPorEM(int idestado,int idmunicipio)
        {
            handler = new HttpClientHandler();
            var model = new Municipio();
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue
                    ("application/json"));
                var Response = await client.GetAsync($"{baseAddress}/api/MinucipiosMX?idestado={idestado}&idmunicipio={idmunicipio}");
                if (Response.IsSuccessStatusCode)
                {
                    model = await Response.Content.ReadAsAsync<Municipio>();
                }
            }
            return model;
        }

        public void Dispose()
        {
            handler.Dispose();
        }
    }
}
