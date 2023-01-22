using ChatApplication.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Dal.NewFolder
{
    public class ChatApplicationContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public ChatApplicationContext(DbContextOptions options) : base(options)
        {

        }
    }
}
