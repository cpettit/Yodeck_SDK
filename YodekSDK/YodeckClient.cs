using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;

namespace YodeckSDK
{
    public class YodeckClient : IDisposable
    {
        private readonly HttpClient _httpClient;
        private bool _disposed;

        /// <summary>
        /// Construct a client for the Yodeck API.
        /// </summary>
        /// <param name="apiToken">
        /// Your API token (from your Yodeck account).
        /// Depending on their docs, you may need "Token" or "Bearer" or something else as prefix.
        /// Check the official Yodeck docs for the correct usage.
        /// </param>
        public YodeckClient(string apiToken)
        {
            // Initialize HttpClient with base address
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://app.yodeck.com/api/v2/")
            };

            // Set default request headers (adjust Authorization scheme as required)
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Token", apiToken);

            // Optional: define JSON as default Accept header
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                _httpClient?.Dispose();
            }
            _disposed = true;
        }
    }
}
