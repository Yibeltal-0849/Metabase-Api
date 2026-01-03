using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System;
using System.Linq; // Added for ToArray() and Contains()
using Microsoft.AspNetCore.Http; // Added for WriteAsync()

namespace metabasapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MetabaseController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private static string _metabaseSessionId;

        public MetabaseController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginToMetabase()
        {
            var loginData = new
            {     //for admin
                username = "yibeltal2514@gmail.com",
                password = "@#Yibie25"

              
            };

            var client = _httpClientFactory.CreateClient();
            var requestContent = new StringContent(
                JsonConvert.SerializeObject(loginData),
                Encoding.UTF8,
                "application/json"
            );

            try
            {
                //  var response = await client.PostAsync("http://localhost:3100/api/session", requestContent); //for local
                var response = await client.PostAsync("http://192.168.0.104:3100/api/session", requestContent);

                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    dynamic parsed = JsonConvert.DeserializeObject(responseBody);
                    _metabaseSessionId = parsed.id;

                    return Ok(new
                    {
                        message = "✅ Login successful",
                        sessionId = _metabaseSessionId
                    });
                }
                else
                {
                    var errorBody = await response.Content.ReadAsStringAsync();
                    return StatusCode((int)response.StatusCode, new
                    {
                        message = "❌ Login failed",
                        error = errorBody
                    });
                }
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, new { message = "❌ Login failed", error = ex.Message });
            }
        }

        [AcceptVerbs("GET", "POST", "PUT", "DELETE", "PATCH", "OPTIONS")]
        [Route("proxy/{**catchAll}")]
        public async Task Proxy()
        {
            if (string.IsNullOrEmpty(_metabaseSessionId))
            {
                Response.StatusCode = 401;
                await Response.WriteAsync("❌ Not logged in.");
                return;
            }

            var client = _httpClientFactory.CreateClient();

            // Get the original path and query
            var originalPath = HttpContext.Request.Path.Value.Replace("/api/Metabase/proxy", "");
            var queryString = HttpContext.Request.QueryString.Value ?? "";

            // Create the request to Metabase
            var request = new HttpRequestMessage
            {
                //  RequestUri = new Uri($"http://localhost:3100{originalPath}{queryString}"),//for local
                RequestUri = new Uri($"http://192.168.0.104:3100{originalPath}{queryString}"),//for production
                // RequestUri = new Uri($"http://localhost:3000/browse/databases/35/schema/report{originalPath}{queryString}"),
                Method = new HttpMethod(HttpContext.Request.Method)
            };

            // Add session cookie
            request.Headers.Add("Cookie", $"metabase.SESSION={_metabaseSessionId}");

            // Forward request body for non-GET requests
            if (HttpContext.Request.ContentLength > 0)
            {
                var memoryStream = new MemoryStream();
                await HttpContext.Request.Body.CopyToAsync(memoryStream);
                memoryStream.Position = 0;
                request.Content = new StreamContent(memoryStream);

                // Copy content type
                if (!string.IsNullOrEmpty(HttpContext.Request.ContentType))
                {
                    request.Content.Headers.TryAddWithoutValidation("Content-Type", HttpContext.Request.ContentType);
                }
            }

            try
            {
                var response = await client.SendAsync(request);

                // Copy status code
                Response.StatusCode = (int)response.StatusCode;

                // Filter and copy valid headers
                foreach (var header in response.Headers)
                {
                    if (!IsInvalidHttp2Header(header.Key))
                    {
                        Response.Headers[header.Key] = header.Value.ToArray();
                    }
                }

                foreach (var header in response.Content.Headers)
                {
                    if (!IsInvalidHttp2Header(header.Key))
                    {
                        Response.Headers[header.Key] = header.Value.ToArray();
                    }
                }

                // Ensure content-type is set properly
                if (response.Content.Headers.ContentType != null)
                {
                    Response.ContentType = response.Content.Headers.ContentType.ToString();
                }

                // Copy content
                await response.Content.CopyToAsync(Response.Body);
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                await Response.WriteAsync($"Proxy error: {ex.Message}");
            }
        }

        private bool IsInvalidHttp2Header(string headerName)
        {
            var invalidHeaders = new[] {
                "Connection",
                "Transfer-Encoding",
                "Keep-Alive",
                "Upgrade",
                "Proxy-Connection"
            };

            return invalidHeaders.Contains(headerName, StringComparer.OrdinalIgnoreCase);
        }
    }
}