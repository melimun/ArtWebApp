using ArtWebApp.Models;
using System;
using System.Linq;

namespace ArtWebApp.Data
{
    public static class UserInitializer
    {
        public static void Initialize(ArtContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Users
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
                new User{
                    UserId = 1050, 
                    Username = "john_doe", 
                    PasswordHash = "RKPX?ATJw#6t)YCLf'7+^", 
                    Email = "john_doe@email.com"
                },

                new User{
                    UserId = 1051, 
                    Username = "jane_doe", 
                    PasswordHash = "c_dRLvhB7XJE5m(j#M2Zg+", 
                    Email = "jane_doe@email.com"
                }
            };

            context.Users.AddRange(users);
            context.SaveChanges();

            var profiles = new Profile[]
            {
                new Profile{
                    ProfileID = 1050,
                    UserID = 1050,
                    Bio = "I am John Doe",
                    ProfileImage = "image.jpg",
                    School = "Sheridan College",
                    PhoneNumber = "123-123-1234",
                    Birthday = "05/05/2012",
                },

                new Profile{
                    ProfileID = 1051,
                    UserID = 1051,
                    Bio = "I am Jane Doe",
                    ProfileImage = "image.jpg",
                    School = "Toronto Metropolitan University",
                    PhoneNumber = "123-123-1234",
                    Birthday = "05/05/2012",
                }
            };

            context.Profiles.AddRange(profiles);
            context.SaveChanges();

            var messages = new Message[]
            {
                new Message{
                    MessageId = 1,
                    UserId = 1050,
                    receiver = 1051,
                    message = "Hey! How are you doing?"
                },

                new Message{
                    MessageId = 2,
                    UserId = 1051,
                    receiver = 1050,
                    message = "I'm doing good!"
                }
            };

            context.Messages.AddRange(messages);
            context.SaveChanges();
        }
    }
}
