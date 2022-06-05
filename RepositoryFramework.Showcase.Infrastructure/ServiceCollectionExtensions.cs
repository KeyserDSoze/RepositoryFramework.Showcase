using Microsoft.Extensions.DependencyInjection;
using RepositoryFramework.Showcase.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFramework.Showcase.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddUserStorage(this IServiceCollection services) 
            => services.AddRepository<User, UserStorage>(ServiceLifetime.Scoped);
    }
}
