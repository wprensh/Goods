using Goods.Api.Aplication.Contract.Services;
using Goods.Api.Aplication.Services;
using Goods.Api.DataAccess.Contracts.Repository;
using Goods.Api.DataAccess.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goods.Api.CrossCutting.Register
{
    public static class IoCRegister
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            AddRegistrationServices(services);
            AddRegistrationServicesRepository(services);
            return services;
        }

        private static IServiceCollection AddRegistrationServicesRepository(IServiceCollection services) 
        {
            services.AddTransient<IAdminRepository, AdminRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            return services;
        }

        private static IServiceCollection AddRegistrationServices(IServiceCollection services)
        {
            services.AddTransient<IAdminService, AdminService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ICovitServices, CovitServices>();
            return services;
        }
    }
}
