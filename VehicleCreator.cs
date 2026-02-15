using modul_HW4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_HW4
{
    internal abstract class VehicleCreator
    {
        public abstract IVehicle CreateVehicle();

        public void Start()
        {
            var vehicle = CreateVehicle();
            vehicle.Drive();
            vehicle.Refuel();
        }
    }
}