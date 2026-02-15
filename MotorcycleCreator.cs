using modul_HW4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_HW4
{
    internal class MotorcycleCreator : VehicleCreator
    {
        string type { get; set; }
        string volume { get; set; }
        public MotorcycleCreator(string type, string volume)
        {
            this.type = type;
            this.volume = volume;
        }

        public override IVehicle CreateVehicle()
        {
            return new Motorcycle(type, volume);
        }
    }
}