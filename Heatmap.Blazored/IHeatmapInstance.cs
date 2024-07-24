namespace Heatmap.Blazored
{
    public interface IHeatmapInstance : IAsyncDisposable
    {
        Task AddData(DataPoint data);
        Task AddData(ICollection<DataPoint> data);
        Task<DataObject> GetData();
        Task Repaint();
        Task SetData(DataObject data);
        Task SetDataMax(double max);
        Task SetDataMin(double min);
    }
}