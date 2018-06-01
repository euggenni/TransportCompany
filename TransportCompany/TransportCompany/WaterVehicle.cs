using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    abstract class WaterVehicle : Vehicle
    {
        public WaterVehicle(uint Speed, uint Carrying, string Brand, uint CountStaff, uint CountPassenger)
            : base(Speed, Carrying, Brand, CountStaff, CountPassenger) { }

        public WaterVehicle(uint Speed, uint Carrying)
            : base(Speed, Carrying) { }

        public WaterVehicle()
            : base() { }
    }
}
