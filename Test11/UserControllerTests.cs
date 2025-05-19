using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Test11
{
    using System.Net.Http.Json;
    using Domain.Entities;
    using FluentAssertions;
    using Xunit;

    public class UserEndpointsTests : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly HttpClient _client;

        public UserEndpointsTests(CustomWebApplicationFactory factory)
        {
            _client = factory.CreateClient();
        }

        [Theory]
        [InlineData("by-email", "user@example.com")]
        [InlineData("by-fullname", "John", "Doe")]
        public async Task GetUserEndpoints_ShouldReturnOk(string endpoint, params string[] parameters)
        {
            string url = endpoint switch
            {
                "by-email" => $"api/User/by-email?email={parameters[0]}",
                "by-fullname" => $"api/User/by-fullname?name={parameters[0]}&surname={parameters[1]}",
                _ => throw new ArgumentException("Invalid endpoint")
            };

            var response = await _client.GetAsync(url);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);

            var user = await response.Content.ReadFromJsonAsync<User>();

            user.Should().NotBeNull();
            // Можна додати додаткові перевірки, наприклад:
            user.Email.Should().Be(parameters[0]);
        }
    }
}
