# Heatmap.Blazored
C# wrapper for [pa7/heatmap.js](https://github.com/pa7/heatmap.js) so you can stay in C#

## How to use
Register the service
```c#
services.AddHeatmapService()
```
Inject and use in your componets `OnAfterRender{Async}` method as it uses JS Interops.

```c#
@using Heatmap.Blazored
@implements IAsyncDisposable
@inject IHeatmapService HeatmapService

<h1 @ref="_element">Example</h1>

@code {
	private ElementReference _element;
	private IHeatmapInstance? _instance;

	protected override async Task OnAfterRenderAsync(bool firstRender)
	{
		if (firstRender)
		{
			_instance = await HeatmapService.Create(new() { Container = _element });
			await _instance.SetData(new DataObject()
				{
					Min = 0,
					Max = 5,
					Data = [
						new DataPoint() {
							X = 50,
							Y = 50,
							Value = 5
						}
					]
				});
		}
	}

	public async ValueTask DisposeAsync()
	{
		if(_instance is not null)
		{
			await _instance.DisposeAsync();
		}
	}
}
```

## Docs
You can use [heatmap.js docs](https://www.patrick-wied.at/static/heatmapjs/docs.html) just switching methods from camelCase to PascalCase.