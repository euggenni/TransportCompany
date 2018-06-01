using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class Helicopter : AerialVehicle
    {
        public uint Speed
        {
            get { return Speed; }
            set 
            {
                if (value <= 800)
                {
                    Speed = value;
                }
                else
                { 
                    throw new OverflowException("Величина скорости у вертолета фантастична.");
                }
            }
        }
        public uint Carrying
        {
            get { return Carrying; }
            set
            {
                if (value <= 50000)
                {
                    Carrying = Carrying;
                }
                else
                {
                    throw new OverflowException("Величина грузоподъемности у вертолета фантастична.");
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
                if (value <= 10)
                {
                    CountStaff = value;
                }
                else
                {
                    throw new OverflowException("Количество персонала у вертолета фантастично.");
                }
            }
        }
        public uint CountPassenger
        {
            get { return CountPassenger; }
            set
            {
                if (value <= 600)
                {
                    CountPassenger = value;
                }
                else
                {
                    throw new OverflowException("Количество пассажиров у вертолета фантастично.");
                }
            }
        }

        public Helicopter(uint Speed, uint Carrying, string Brand, uint CountStaff, uint CountPassenger) 
            : base(Speed, Carrying, Brand, CountStaff, CountPassenger) { }

        public Helicopter(uint Speed, uint Carrying)
            : base(Speed, Carrying) { }

        public Helicopter()
            : base() { }
    }
}
