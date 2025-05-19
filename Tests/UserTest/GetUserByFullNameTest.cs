using Application.Auth.Queries.GetUserByFullName;
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
    public class GetUserByFullNameTest
    {
        [Fact]
        public async Task Handle_ShouldReturnUser_WhenUserExistsWithGivenFullName()
        {
            // Arrange
            var name = "John";
            var surname = "Doe";
            var expectedUser = new User { Name = name, Surname = surname, Email = "john.doe@example.com" };
            var userRepositoryMock = new Mock<IUserRepository>();
            userRepositoryMock
                .Setup(repo => repo.GetUserByFullNameAsync(name, surname))
                .ReturnsAsync(expectedUser);

            var handler = new GetUserByFullNameQueryHandler(userRepositoryMock.Object);
            var query = new GetUserByFullNameQuery(name, surname);

            // Act
            var result = await handler.Handle(query, CancellationToken.None);

            // Assert
            result.Should().NotBeNull();
            result.Should().BeEquivalentTo(expectedUser);
        }

        [Fact]
        public async Task Handle_ShouldReturnNull_WhenUserDoesNotExist()
        {
            // Arrange
            var name = "Jane";
            var surname = "Smith";

            var userRepositoryMock = new Mock<IUserRepository>();
            userRepositoryMock
                .Setup(repo => repo.GetUserByFullNameAsync(name, surname))
                .ReturnsAsync((User?)null);

            var handler = new GetUserByFullNameQueryHandler(userRepositoryMock.Object);
            var query = new GetUserByFullNameQuery(name, surname);

            // Act
            var result = await handler.Handle(query, CancellationToken.None);

            // Assert
            result.Should().BeNull();
        }
    }
}
