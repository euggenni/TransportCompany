using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class Aircraft : AerialVehicle
    {
        public uint Speed
        {
            get { return Speed; }
            set 
            {
                if (value <= 15000)
                {
                    Speed = value;
                }
                else
                { 
                    throw new OverflowException("Величина скорости у самолета фантастична.");
                }
            }
        }
        public uint Carrying
        {
            get { return Carrying; }
            set
            {
                if (value <= 250000)
                {
                    Carrying = Carrying;
                }
                else
                {
                    throw new OverflowException("Величина грузоподъемности у самолета фантастична.");
                }
            }
        }
        public string Brand
        {
            get { return Brand; }
            set { Brand = value; }
        }
        public uint CountStaff
        {
            get { return CountStaff; }
            set 
            {
                if (value <= 40)
                {
                    CountStaff = value;
                }
                else
                {
                    throw new OverflowException("Количество персонала у самолета фантастично.");
                }
            }
        }
        public uint CountPassenger
        {
            get { return CountPassenger; }
            set
            {
                if (value <= 1000)
                {
                    CountPassenger = value;
                }
                else
                {
                    throw new OverflowException("Количество пассажиров у самолета фантастично.");
                }
            }
        }

        public Aircraft(uint Speed, uint Carrying, string Brand, uint CountStaff, uint CountPassenger) 
            : base(Speed, Carrying, Brand, CountStaff, CountPassenger) { }

        public Aircraft(uint Speed, uint Carrying)
            : base(Speed, Carrying) { }

        public Aircraft()
            : base() { }
    }
}
