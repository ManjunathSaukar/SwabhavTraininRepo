using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Model
{
    internal class Inventory
    {
        private List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void AddGuitar(string serialNumber, double price, string builder, string model, string type, string backWood, string topWood)
        {
            Guitar guitar = new Guitar(serialNumber, price, builder, model, type, backWood, topWood);
            guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            foreach (Guitar guitar in guitars)
            {
                if (guitar.SerialNumber == serialNumber)
                {
                    return guitar;
                }
            }
            return null;
        }

        public Guitar Search(Guitar searchGuitar)
        {
            foreach (Guitar guitar in guitars)
            {
                if (!StringsMatch(guitar.Builder, searchGuitar.Builder))
                    continue;
                if (!StringsMatch(guitar.Model, searchGuitar.Model))
                    continue;
                if (!StringsMatch(guitar.Type, searchGuitar.Type))
                    continue;
                if (!StringsMatch(guitar.BackWood, searchGuitar.BackWood))
                    continue;
                if (!StringsMatch(guitar.TopWood, searchGuitar.TopWood))
                    continue;

                return guitar;
            }
            return null;
        }

        private bool StringsMatch(string a, string b)
        {
            return string.Equals(a, b, StringComparison.OrdinalIgnoreCase);
        }
    }
}
