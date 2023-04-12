using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Model
{
    internal class Guitar
    {
        public Guitar(string serialNumber, double price, string builder, string model, string type, string backWood, string topWood)
        {
            SerialNumber = serialNumber;
            Price = price;
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
        }
        public string SerialNumber { get; }
        public double Price { get; }
        public string Builder { get; }
        public string Model { get; }
        public string Type { get; }
        public string BackWood { get; }
        public string TopWood { get; }

        
    }
}
