using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class Train : GroundVehicle
    {
        public uint Speed
        {
            get { return Speed; }
            set 
            {
                if (value <= 1500)
                {
                    Speed = value;
                }
                else
                { 
                    throw new OverflowException("Величина скорости у поезда фантастична.");
                }
            }
        }
        public uint Carrying
        {
            get { return Carrying; }
            set
            {
                if (value <= 100000000)
                {
                    Carrying = Carrying;
                }
                else
                {
                    throw new OverflowException("Величина грузоподъемности у поезда фантастична.");
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
                if (value <= 300)
                {
                    CountStaff = value;
                }
                else
                {
                    throw new OverflowException("Количество персонала у поезда фантастично.");
                }
            }
        }
        public uint CountPassenger
        {
            get { return CountPassenger; }
            set
            {
                if (value <= 10000)
                {
                    CountPassenger = value;
                }
                else
                {
                    throw new OverflowException("Количество пассажиров у поезда фантастично.");
                }
            }
        }

        public Train(uint Speed, uint Carrying, string Brand, uint CountStaff, uint CountPassenger) 
            : base(Speed, Carrying, Brand, CountStaff, CountPassenger) { }

        public Train(uint Speed, uint Carrying)
            : base(Speed, Carrying) { }

        public Train()
            : base() { }
    }
}