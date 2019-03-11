using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagementWeb.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TaskManagementWebContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TaskManagementWebContext>>()))
            {
                // Look for any movies.
                //if (context.Mission.Any())
                //{
                //    return;   // DB has been seeded
                //}

                context.Mission.AddRange(
                    new Mission
                    {
                        Description = "Mission Impossible",
                        AddTime = DateTime.Now,
                        CompleteTime = DateTime.Parse("1989-2-12"),
                        Completed = false,
                        Dotted = false
                    },

                    new Mission
                    {
                        Description = "Mission Total Possible",
                        AddTime = DateTime.Now,
                        CompleteTime = DateTime.Parse("1999-2-12"),
                        Completed = false,
                        Dotted = false
                    },

                    new Mission
                    {
                        Description = "Not Again",
                        AddTime = DateTime.Now,
                        CompleteTime = DateTime.Parse("2019-2-12"),
                        Completed = false,
                        Dotted = false
                    },

                    new Mission
                    {
                        Description = "Brush Teeth",
                        AddTime = DateTime.Now,
                        CompleteTime = DateTime.Parse("2019-2-12"),
                        Completed = false,
                        Dotted = false
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
