using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OfferMicroservice.Models
{
    public class OfferHelper
    {
        public HttpClient Initial()
        {
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (sender, certificate, chain, errors) => true; 
            var client = new HttpClient(httpClientHandler);
            client.BaseAddress = new Uri("https://localhost:44389/");
            return client;
        }
    }
}
