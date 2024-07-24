using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heatmap.Blazored
{
    public struct DataPoint
    {
        /// <summary>
        ///  x coordinate of the datapoint
        /// </summary>
        public double X { get; set; }

        /// <summary>
        ///  y coordinate of the datapoint
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        ///  value at datapoint(x, y)
        /// </summary>
        public double Value { get; set; }
    }
}
