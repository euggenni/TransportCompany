using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class Car : GroundVehicle
    {
        public uint Speed
        {
            get { return Speed; }
            set 
            {
                if (value <= 2000)
                {
                    Speed = value;
                }
                else
                { 
                    throw new OverflowException("Величина скорости у автомобиля фантастична.");
                }
            }
        }
        public uint Carrying
        {
            get { return Carrying; }
            set
            {
                if (value <= 500000)
                {
                    Carrying = Carrying;
                }
                else
                {
                    throw new OverflowException("Величина грузоподъемности у автомобиля фантастична.");
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
                if (value <= 20)
                {
                    CountStaff = value;
                }
                else
                {
                    throw new OverflowException("Количество персонала у автомобиля фантастично.");
                }
            }
        }
        public uint CountPassenger
        {
            get { return CountPassenger; }
            set
            {
                if (value <= 400)
                {
                    CountPassenger = value;
                }
                else
                {
                    throw new OverflowException("Количество пассажиров у автомобиля фантастично.");
                }
            }
        }

        public Car(uint Speed, uint Carrying, string Brand, uint CountStaff, uint CountPassenger) 
            : base(Speed, Carrying, Brand, CountStaff, CountPassenger) { }

        public Car(uint Speed, uint Carrying)
            : base(Speed, Carrying) { }

        public Car()
            : base() { }
    }
}
