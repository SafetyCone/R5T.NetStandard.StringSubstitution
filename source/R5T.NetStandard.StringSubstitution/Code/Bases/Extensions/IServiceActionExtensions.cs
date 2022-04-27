using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0062;
using R5T.T0063;


namespace R5T.NetStandard.StringSubstitution
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="PercentStringSubstitutionScheme"/> implementation of <see cref="IStringSubstitutionScheme"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IStringSubstitutionScheme> AddPercentStringSubstitutionSchemeAction(this IServiceAction _)
        {
            var serviceAction = _.New<IStringSubstitutionScheme>(services => services.AddPercentStringSubstitutionScheme());
            return serviceAction;
        }
    }
}
