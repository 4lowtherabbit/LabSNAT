using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LabSNAT.Controllers
{
    public class ReproController : Controller
    {
        // GET: Repro
        public string Index(string url)
        {
            var request = HttpWebRequest.Create(url);
            request.GetResponse();

            return "OK";
        }

        public string Fin(string url)
        {
            var request = HttpWebRequest.Create(url);
            var response = request.GetResponse();
            response.Close();

            return "OK";
        }

        public async Task<string> Client(string url)
        {
            using (var client = new HttpClient())
            {
                await client.GetAsync(url);
            }

            return "OK";
        }

        private static Lazy<HttpClient> _client = new Lazy<HttpClient>();

        public async Task<string> ReuseClient(string url)
        {
            var client = _client.Value;
            await client.GetAsync(url);
            return "OK";
        }
    }
}