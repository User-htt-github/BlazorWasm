using Blazor.API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Blazor.API.Data
{
    public class BlazorDbContextSeed
    {
        private readonly IPasswordHasher<User> passwordHasher = new PasswordHasher<User>();
        private readonly ModelBuilder modelBuilder;
        public BlazorDbContextSeed(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            var user = new User {
                Id = Guid.NewGuid(),
                FirstName = "People",
                LastName = "Anon",
                Email = "hungttworking@gmail.com",
                PhoneNumber = "1234567890",
                UserName = "admin",
            };
            user.PasswordHash = passwordHasher.HashPassword(user, "123456");

            modelBuilder.Entity<User>().HasData(
                   user
            );

            modelBuilder.Entity<Entities.Task>().HasData(
                   new Entities.Task() {
                       Id = Guid.NewGuid(),
                       Name = "Task 1",
                       CreatedDate = DateTime.Now,
                       Priority = Enums.Priority.Low,
                       Status = Enums.Status.New,
                       AssigneeId = user.Id
                   }
            );
        }
    }
}
