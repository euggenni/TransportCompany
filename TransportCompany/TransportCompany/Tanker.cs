using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class Tanker : WaterVehicle
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
                    throw new OverflowException("Величина скорости у танкера фантастична.");
                }
            }
        }
        public uint Carrying
        {
            get { return Carrying; }
            set
            {
                if (value <= 300000000)
                {
                    Carrying = Carrying;
                }
                else
                {
                    throw new OverflowException("Величина грузоподъемности у танкера фантастична.");
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
                if (value <= 60)
                {
                    CountStaff = value;
                }
                else
                {
                    throw new OverflowException("Количество персонала у танкера фантастично.");
                }
            }
        }
        public uint CountPassenger
        {
            get { return CountPassenger; }
            set
            {
                if (value == 0)
                {
                    CountPassenger = value;
                }
                else
                {
                    throw new OverflowException("У танкера не бывает пассажиров.");
                }
            }
        }

        public Tanker(uint Speed, uint Carrying, string Brand, uint CountStaff, uint CountPassenger) 
            : base(Speed, Carrying, Brand, CountStaff, CountPassenger) { }

        public Tanker(uint Speed, uint Carrying)
            : base(Speed, Carrying) { }

        public Tanker()
            : base() { }
    }
}
