using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace WebsiteMonitor.Api.Test
{
    public class PingControllerIntegrationTests : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public PingControllerIntegrationTests(CustomWebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task Ping_GetRequest_ReturnsOk()
        {
            // The endpoint or route of the controller action.
            var httpResponse = await _client.GetAsync("/ping");
            Assert.Equal(HttpStatusCode.OK, httpResponse.StatusCode);
        }
    }
}