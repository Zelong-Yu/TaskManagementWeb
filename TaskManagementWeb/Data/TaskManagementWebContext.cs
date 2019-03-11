using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TaskManagementWeb.Models
{
    public class TaskManagementWebContext : DbContext
    {
        public TaskManagementWebContext (DbContextOptions<TaskManagementWebContext> options)
            : base(options)
        {
        }

        public DbSet<TaskManagementWeb.Models.Mission> Mission { get; set; }
    }
}
