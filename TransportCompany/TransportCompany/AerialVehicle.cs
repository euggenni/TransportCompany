using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    abstract class AerialVehicle : Vehicle
    {
        public AerialVehicle(uint Speed, uint Carrying, string Brand, uint CountStaff, uint CountPassenger)
            : base(Speed, Carrying, Brand, CountStaff, CountPassenger) { }

        public AerialVehicle(uint Speed, uint Carrying)
            : base(Speed, Carrying) { }

        public AerialVehicle()
            : base() { }
    }
}
