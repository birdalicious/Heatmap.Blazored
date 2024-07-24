using Microsoft.AspNetCore.Components;

namespace Heatmap.Blazored
{
    public struct ConfigObject
    {
        public ElementReference Container { get; set; }

        /// <summary>
        /// A background color string in form of hexcode, color name, or rgb(a)
        /// </summary>
        public string? BackgroundColor { get; set; }

        /// <summary>
        /// An object that represents the gradient (syntax: number string [0,1] : color string), check out the example
        /// </summary>
        public Dictionary<double, string>? Gradient { get; set; }

        /// <summary>
        /// The radius each datapoint will have (if not specified on the datapoint itself)
        /// </summary>
        public double? Radius { get; set; }

        /// <summary>
        /// A global opacity for the whole heatmap. This overrides maxOpacity and minOpacity if set
        /// </summary>
        public double? Opacity { get; set; }

        /// <summary>
        /// The maximal opacity the highest value in the heatmap will have. (will be overridden if opacity set)
        /// </summary>
        public double? MaxOpacity { get; set; }

        /// <summary>
        /// The minimum opacity the lowest value in the heatmap will have (will be overridden if opacity set)
        /// </summary>
        public double? MinOpacity { get; set; }

        /// <summary>
        /// The blur factor that will be applied to all datapoints. The higher the blur factor is, the smoother the gradients will be
        /// </summary>
        public double? Blur { get; set; }

        /// <summary>
        /// The property name of your x coordinate in a datapoint
        /// default = "x"
        /// </summary>
        public string? XField { get; set; }

        /// <summary>
        /// The property name of your y coordinate in a datapoint
        /// default = "y"
        /// </summary>
        public string? YField { get; set; }

        /// <summary>
        /// The property name of your y coordinate in a datapoint
        /// default = "value"
        /// </summary>
        public string? ValueField { get; set; }
    }
}