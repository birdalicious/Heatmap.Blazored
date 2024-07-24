using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heatmap.Blazored
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddHeatmapService(this IServiceCollection services)
        {
            return services.AddScoped<IHeatmapService, HeatmapService>();
        }
    }
}
