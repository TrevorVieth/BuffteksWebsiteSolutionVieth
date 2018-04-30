using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace BuffteksWebsite.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BuffteksWebsiteContext(
                serviceProvider.GetRequiredService<DbContextOptions<BuffteksWebsiteContext>>()))
            {
                // Look for any movies.
                if (context.Member.Any())
                {
                    return;   // DB has been seeded
                }

                context.Member.AddRange(
                     new Member
                     {
                         MemberID = 1,
                         FirstName = "Trevor",
                         LastName = "Vieth",
                         Standing = "Junior",
                         Major = "BA-CIS",
                         Birthday = "12/21/1996",
                         Email = "TrevorDLV@Gmail.com",
                         Phone = "806-681-5067",
                     },

                     new Member
                     {
                         MemberID = 1,
                         FirstName = "John",
                         LastName = "Kieth",
                         Standing = "Junior",
                         Major = "CIS",
                         Birthday = "12/21/1996",
                         Email = "TrevorDLV@Gmail.com",
                         Phone = "806-681-5067",
                     }
                    
                );






                context.Client.AddRange(
                     new Client
                     {
                         ClientID = 1,
                         FirstName = "Bob",
                         LastName = "Jones",
                         Email = "Bob-Jones@Gmail.com",
                         Phone = "806-555-6184"

                     }




                );

                context.Project.AddRange(
                     new Project
                     {
                         ProjectID = 1,
                         ClientsAssigned = "Bob Jones",
                         MembersAssigned = "Trevor Vieth",
                         Description = "Make blabla",
                         DueDate = "4/21/2018",

                     }
                );
                context.SaveChanges();
            }
        }
    }
}