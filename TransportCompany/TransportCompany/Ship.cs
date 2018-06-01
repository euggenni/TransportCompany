using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class Ship : WaterVehicle
    {
        public uint Speed
        {
            get { return Speed; }
            set 
            {
                if (value <= 60)
                {
                    Speed = value;
                }
                else
                { 
                    throw new OverflowException("Величина скорости у лайнера фантастична.");
                }
            }
        }
        public uint Carrying
        {
            get { return Carrying; }
            set
            {
                if (value <= 1000000)
                {
                    Carrying = Carrying;
                }
                else
                {
                    throw new OverflowException("Величина грузоподъемности у лайнера фантастична.");
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
                if (value <= 5000)
                {
                    CountStaff = value;
                }
                else
                {
                    throw new OverflowException("Количество персонала у лайнера фантастично.");
                }
            }
        }
        public uint CountPassenger
        {
            get { return CountPassenger; }
            set
            {
                if (value <= 20000)
                {
                    CountPassenger = value;
                }
                else
                {
                    throw new OverflowException("Количество пассажиров у лайнера фантастично.");
                }
            }
        }

        public Ship(uint Speed, uint Carrying, string Brand, uint CountStaff, uint CountPassenger) 
            : base(Speed, Carrying, Brand, CountStaff, CountPassenger) { }

        public Ship(uint Speed, uint Carrying)
            : base(Speed, Carrying) { }

        public Ship()
            : base() { }
    }
}
