namespace Heatmap.Blazored
{
    public interface IHeatmapService
    {
        Task<IHeatmapInstance> Create(ConfigObject config);
    }
}