using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_13_07
{
    internal class Device
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Cost { get; set; }
        public Device(string name, string manufacturer, int cost)
        {
            Name = name;
            Manufacturer = manufacturer;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"{Name}, {Manufacturer}, {Cost}";
        }

        
    }
}
