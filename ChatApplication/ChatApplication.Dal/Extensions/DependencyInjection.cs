using ChatApplication.Dal.NewFolder;
using ChatApplication.Dal.Repositories;
using ChatApplication.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Dal.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDal(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ChatApplicationContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("Default")));

            services.AddScoped<IUserProfileRepository, UserProfileRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<IReplyRepository, ReplyRepository>();

            return services;
        }
    }
}
