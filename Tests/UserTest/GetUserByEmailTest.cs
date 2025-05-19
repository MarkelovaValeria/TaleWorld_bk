using Application.Auth.Queries.Users;
using Domain.Entities;
using FluentAssertions;
using Infrastructure.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests.UserTest
{
    public class GetUserByEmailTest
    {
        [Fact]
        public async Task Handle_ShouldReturnUser_WhenUserExists()
        {
            // Arrange
            var email = "test@example.com";
            var expectedUser = new User { Email = email, Name = "John", Surname = "Doe" };

            var mockRepo = new Mock<IUserRepository>();
            mockRepo
                .Setup(repo => repo.GetUserByEmailAsync(email))
                .ReturnsAsync(expectedUser);

            var handler = new GetUserByEmailQueryHandler(mockRepo.Object);
            var query = new GetUserByEmailQuery(email);

            // Act
            var result = await handler.Handle(query, CancellationToken.None);

            // Assert
            result.Should().NotBeNull();
            result.Should().BeEquivalentTo(expectedUser);
        }

        [Fact]
        public async Task Handle_ShouldThrowInvalidOperationException_WhenUserDoesNotExist()
        {
            // Arrange
            var email = "notfound@example.com";

            var mockRepo = new Mock<IUserRepository>();
            mockRepo
                .Setup(repo => repo.GetUserByEmailAsync(email))
                .ReturnsAsync((User)null); // симуляція неіснуючого користувача

            var handler = new GetUserByEmailQueryHandler(mockRepo.Object);
            var query = new GetUserByEmailQuery(email);

            // Act
            Func<Task> act = async () => await handler.Handle(query, CancellationToken.None);

            // Assert
            await act.Should()
                     .ThrowAsync<InvalidOperationException>()
                     .WithMessage($"User with email {email} not found.");
        }
    }
}
