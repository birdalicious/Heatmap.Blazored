using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heatmap.Blazored
{
    public struct DataObject
    {
        public double Min { get; set; }
        public double Max { get; set; }
        public ICollection<DataPoint> Data { get; set; }
    }
}
