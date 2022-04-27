using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;


namespace R5T.NetStandard.StringSubstitution
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="PercentStringSubstitutionScheme"/> implementation of <see cref="IStringSubstitutionScheme"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddPercentStringSubstitutionScheme(this IServiceCollection services)
        {
            services.AddSingleton<IStringSubstitutionScheme, PercentStringSubstitutionScheme>();

            return services;
        }
    }
}
