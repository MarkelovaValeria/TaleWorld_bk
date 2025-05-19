using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Domain.Entities;
using FluentAssertions;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace Tests.UserTest
{
    public class AddUserTests
    {
        private readonly Mock<DbSet<User>> _mockUserDbSet;
        private readonly Mock<TWDbContext> _mockContext;
        private readonly UserRepository _repository;
        public AddUserTests()
        {
            _mockUserDbSet = new Mock<DbSet<User>>();
            _mockContext = new Mock<TWDbContext>();
            _mockContext.Setup(c => c.Users).Returns(_mockUserDbSet.Object);
            _repository = new UserRepository(_mockContext.Object);
        }

        [Fact]
        public async Task AddUserAsync_ValidUser_AddsUserAndSavesChanges()
        {
            // Arrange
            var user = new User { Id = 1, Email = "test@example.com", Name = "Test", Surname = "User" };

            _mockUserDbSet.Setup(d => d.AddAsync(user, It.IsAny<CancellationToken>()))
                .ReturnsAsync((Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<User>)null!);
            _mockContext.Setup(c => c.SaveChangesAsync(It.IsAny<CancellationToken>())).ReturnsAsync(1);

            // Act
            await _repository.AddUserAsync(user);

            // Assert
            _mockUserDbSet.Verify(d => d.AddAsync(user, It.IsAny<CancellationToken>()), Times.Once);
            _mockContext.Verify(c => c.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}