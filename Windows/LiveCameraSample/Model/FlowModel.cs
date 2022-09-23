using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCameraSample.Model
{
    internal class FlowModel
    {
        public string shape { get; set; }
        public string color { get; set; }
        public string description { get; set; }
        public string image { get; set; }

        public FlowModel(string shape, string color, string description, string image)
        {
            this.shape = shape;
            this.color = color;
            this.description = description;
            this.image = image;
        }
    }
}
