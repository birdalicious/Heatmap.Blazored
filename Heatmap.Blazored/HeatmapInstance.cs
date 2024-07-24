using Microsoft.JSInterop;

namespace Heatmap.Blazored
{
    internal class HeatmapInstance : IHeatmapInstance
    {
        private readonly IJSObjectReference _instance;
        public HeatmapInstance(IJSObjectReference instance)
        {
            _instance = instance;
        }

        public async Task AddData(DataPoint data)
        {
            await _instance.InvokeVoidAsync("addData", data);
        }

        public async Task AddData(ICollection<DataPoint> data)
        {
            await _instance.InvokeVoidAsync("addData", data);
        }

        public async Task SetData(DataObject data)
        {
            await _instance.InvokeVoidAsync("setData", data);
        }

        public async Task SetDataMax(double max)
        {
            await _instance.InvokeVoidAsync("setDataMax", max);
        }

        public async Task SetDataMin(double min)
        {
            await _instance.InvokeVoidAsync("setDataMin", min);
        }

        public async Task<DataObject> GetData()
        {
            return await _instance.InvokeAsync<DataObject>("getData");
        }

        public async Task Repaint()
        {
            await _instance.InvokeVoidAsync("repaint");
        }

        public ValueTask DisposeAsync()
        {
            return _instance.DisposeAsync();
        }
    }
}