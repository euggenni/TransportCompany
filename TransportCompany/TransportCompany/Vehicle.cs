using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class Vehicle
    {
        private uint speed; //скорость транспортного средства (км/ч)
        private uint carrying; //грузоподъемность (кг)
        private string brand; //марка
        private uint countStaff; //количество персонала
        private uint countPassenger; //количество пассажиров

        public uint Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public uint Carrying
        {
            get { return carrying; }
            set { carrying = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public uint CountStaff
        {
            get { return countStaff; }
            set { countStaff = value; }
        }

        public uint CountPassenger
        {
            get { return countPassenger; }
            set { countPassenger = value; }
        }

        public Vehicle(uint Speed, uint Carrying, string Brand, uint CountStaff, uint CountPassenger) :this(Speed, Carrying)
        {
            this.brand = Brand;
            this.countStaff = CountStaff;
            this.countPassenger = CountPassenger;
        }

        public Vehicle(uint Speed, uint Carrying) : this()
        {
            this.speed = Speed;
            this.carrying = Carrying;
        }
        
        public Vehicle()
        {
            this.speed = 0;
            this.carrying = 0;
            this.brand = "Unknown";
            this.countStaff = 0;
            this.countPassenger = 0;
        }

        public string FullInformation() //выводит полную информацию о транспортном средстве
        {
            string Result = "";
            Result += "Скорость: " + this.speed + "; ";
            Result += "Грузоподъемность: " + this.carrying + "; ";
            Result += "Марка: " + this.brand + "; ";
            Result += "Количество персонала: " + this.countStaff + "; ";
            Result += "Количество пассажиров: " + this.countPassenger + ".";
            return Result;
        }

        public void DeliverCargo() //доставляет грузы
        {
            Console.WriteLine("Груз доставлен");
        }
    }
}
