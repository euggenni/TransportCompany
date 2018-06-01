using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    abstract class GroundVehicle : Vehicle
    {
        public GroundVehicle(uint Speed, uint Carrying, string Brand, uint CountStaff, uint CountPassenger)
            : base(Speed, Carrying, Brand, CountStaff, CountPassenger) { }

        public GroundVehicle(uint Speed, uint Carrying)
            : base(Speed, Carrying) { }

        public GroundVehicle()
            : base() { }
    }
}
