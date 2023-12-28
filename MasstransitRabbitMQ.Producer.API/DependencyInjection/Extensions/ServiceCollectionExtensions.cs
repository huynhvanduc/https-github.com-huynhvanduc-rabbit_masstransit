﻿using MassTransit;
using MasstransitRabbitMQ.Producer.API.DependencyInjection.Options;

namespace MasstransitRabbitMQ.Producer.API.DependencyInjection.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddConfigurationMasstransitRabbitMq(this IServiceCollection services, IConfiguration configuration
            )
        {
            var masstransitConfiguration = new MasstransitConfiguration();
            configuration.GetSection(nameof(MasstransitConfiguration)).Bind(masstransitConfiguration);

            services.AddMassTransit(mt =>
            {
                mt.UsingRabbitMq((context, bus) =>
                {
                    bus.Host(masstransitConfiguration.Host, masstransitConfiguration.VHost, h =>
                    {
                        h.Username(masstransitConfiguration.UserName);
                        h.Password(masstransitConfiguration.Password);
                    });
                });
            });

            return services;
        }
    }
}
