using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http.Json;
using FluentAssertions;
using Xunit;

namespace IntegrationTests.UserTest
{
    public class GetUserByFullNameTest : IClassFixture<CustomWebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;
        public GetUserByFullNameTest(CustomWebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Theory]
        [InlineData("John", "Doe", "john.doe@example.com")]
        [InlineData("Jane", "Smith", "jane.smith@example.com")]
        public async Task GetUserByFullName_ShouldReturnCorrectUser(string name, string surname, string expectedEmail)
        {
            // Act
            var response = await _client.GetAsync($"/api/users/fullname?name={name}&surname={surname}");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var user = await response.Content.ReadFromJsonAsync<UserDto>();
            user.Should().NotBeNull();
            user!.Email.Should().Be(expectedEmail);
        }

        public class UserDto
        {
            public string Email { get; set; }
        }
    }
}
