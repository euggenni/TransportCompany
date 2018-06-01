using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class Menu
    {
        private static byte state = 0; //состояние программы
        private static List<Vehicle> Vehicls = new List<Vehicle>();

        protected static byte State
        {
            get { return Menu.state; }
            set { Menu.state = value; }
        }

        public static void PrintMenu() //распечатывает основное меню
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Введите число соответствующую тому, \nчто вы хотите сделать с транспортными средствами:");
                Console.WriteLine("1 - Добавить новое транспортное средство");
                Console.WriteLine("2 - Просмотреть добавленные транспортные средства");
                Console.WriteLine("3 - Выход");
                ReadState(3);
                switch (State)
                {
                    case 1: //добавление нового транспортного средства
                        {
                            SelectTypeVehicle();
                        } break;
                    case 2: //просмотр добавленных транспортных стредств
                        {
                            PrintVehicls();
                        } break;
                    case 3: //выход
                        {
                            return;
                        } break;
                    default:
                        {
                            Console.WriteLine("Произошла ужасная ошибка, попробуйте ввести еще раз.");
                        } break;
                }
            }
            while (true);
        }

        private static void ReadState(int limit) //считывает введенное значение с клавиатуры
        { 
            bool flag = true; //выводит из зацикленного ввода
            byte Read;
            do
            {
                try
                {
                    Read = Convert.ToByte(Console.ReadLine());
                    if (Read > 0 && Read <= (byte)limit)
                    {
                        State = Read;
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели число не из требуемого интервала, попробуйте ввести еще раз...");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели не число, попробуйте ввести еще раз...");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Вы ввели число не из требуемого интервала, попробуйте ввести еще раз...");
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка ввода, попробуйте ввести еще раз...");
                }
            }
            while (flag);
        }

        private static void SelectTypeVehicle() //меню выбора вида транспортного средства
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Введите цифру соответствующую тому, \nкакой вид транспортного средства вы хотите добавить:");
                Console.WriteLine("1 - Наземные");
                Console.WriteLine("2 - Водные");
                Console.WriteLine("3 - Воздушные");
                Console.WriteLine("4 - Вернуться в меню");
                ReadState(4);
                switch (State)
                {
                    case 1: //добавление наземного транспорта
                        {
                            AddGroungVehicle();
                        } break;
                    case 2: //добавление водного транспорта
                        {
                            AddWaterVehicle();
                        } break;
                    case 3: //добавление воздушного транспорта
                        {
                            AddAerialVehicle();
                        } break;
                    case 4: //возврат в меню
                        {
                            return;
                        } break;
                    default:
                        {
                            Console.WriteLine("Произошла ужасная ошибка, попробуйте ввести еще раз.");
                        } break;
                }
            }
            while (true);
        }

        private static void PrintVehicls() //Выводит на экран все транспортные средства
        {
            Console.Clear();
            if (Vehicls.Count > 0)
            {
                foreach (Vehicle Subject in Vehicls)
                {
                    Console.WriteLine(Subject.GetType() + "; " + Subject.FullInformation());
                }
            }
            else
            {
                Console.WriteLine("Транспортные средства не созданы");
            }
            Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в меню..."); 
            Console.ReadKey();
        }

        private static void CreateVehicle(Vehicle Subject, string Type) //производит считывание с клавиатуры транспортного средства и добавление его в список
        {
            Console.Clear();
            Console.WriteLine(Type);
            Console.WriteLine("Введите скорость транспортного средства:");
            uint Speed = ReadUintParameter();
            Console.WriteLine("Введите грузоподъемность транспортного средства:");
            uint Carrying = ReadUintParameter();
            Console.WriteLine("Продолжить добавление параметров или создать транспортное средство?");
            Console.WriteLine("1 - Создать транспортное средство");
            Console.WriteLine("2 - Продолжить добавление параметров");
            ReadState(2);
            switch (State)
            {
                case 1:
                    {
                        try
                        {
                            Subject.Speed = Speed;
                            Subject.Carrying = Carrying;
                            Vehicls.Add(Subject);
                            Console.WriteLine("Транспортное средство создано.");
                        }
                        catch (OverflowException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ошибка при добавлении нового транспортного средства...");
                        }
                        Console.WriteLine("Нажмите, чтобы вернуться в меню создания...");
                        Console.ReadLine();
                    }break;
                case 2:
                    {
                        Console.WriteLine("Введите марку транспортного средства");
                        string Brand = Console.ReadLine();
                        Console.WriteLine("Введите количество персонала");
                        uint CountStaff = ReadUintParameter();
                        Console.WriteLine("Введите количество пассажиров");
                        uint CountPassenger = ReadUintParameter();
                        try
                        {
                            Subject.Speed = Speed;
                            Subject.Carrying = Carrying;
                            Subject.Brand = Brand;
                            Subject.CountStaff = CountStaff;
                            Subject.CountPassenger = CountPassenger;
                            Vehicls.Add(Subject);
                            Console.WriteLine("Транспортное средство создано.");
                        }
                        catch (OverflowException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ошибка при добавлении нового транспортного средства...");
                        }
                        Console.WriteLine("Нажмите, чтобы вернуться в меню создания...");
                        Console.ReadLine();
                    }break;
                default:
                    {
                        Console.WriteLine("Произошла ужасная ошибка, попробуйте ввести еще раз.");
                    }break;
            }
        }

        private static uint ReadUintParameter() //читает переменную типа uint c клавиатуры
        {
            uint Value = 0;
            bool flag = true;
            do
            {
                try
                {
                    Value = Convert.ToUInt32(Console.ReadLine());
                    flag = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели не число, попробуйте ввести еще раз...");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Вы ввели число не из требуемого интервала, попробуйте ввести еще раз...");
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка ввода, попробуйте ввести еще раз...");
                }
            }
            while (flag);
            return Value;
        }

        private static void AddGroungVehicle() // меню добавления наземного транспорта
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Введите цифру соответствующую тому, \nкакой вид наземного транспорта вы хотите добавить:");
                Console.WriteLine("1 - Поезд");
                Console.WriteLine("2 - Автомобиль");
                Console.WriteLine("3 - Вернуться в меню");
                ReadState(3);
                switch (State)
                {
                    case 1:
                        {
                            CreateVehicle(new Train(), "Добавление поезда");
                        } break;
                    case 2:
                        {
                            CreateVehicle(new Car(), "Добавление автомобиля");
                        } break;
                    case 3:
                        {
                            return;
                        } break;
                    default:
                        {
                            Console.WriteLine("Ошибка при добавлении нового транспортного средства");
                        }break;
                }
            }
            while (true);
        }

        private static void AddWaterVehicle() //меню добавления водного транспорта
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Введите цифру соответствующую тому, \nкакой вид водного транспорта вы хотите добавить:");
                Console.WriteLine("1 - Лайнер");
                Console.WriteLine("2 - Танкер");
                Console.WriteLine("3 - Вернуться в меню");
                ReadState(3);
                switch (State)
                {
                    case 1:
                        {
                            CreateVehicle(new Ship(), "Добавление лайнера");
                        } break;
                    case 2:
                        {
                            CreateVehicle(new Tanker(), "Добавление танкера");
                        } break;
                    case 3:
                        {
                            return;
                        } break;
                    default:
                        {
                            Console.WriteLine("Ошибка при добавлении нового транспортного средства");
                        } break;
                }
            }
            while (true);
        }

        private static void AddAerialVehicle() //меню добавления воздушного вида транспорта
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Введите цифру соответствующую тому, \nкакой вид воздушного транспорта вы хотите добавить:");
                Console.WriteLine("1 - Самолет");
                Console.WriteLine("2 - Вертолет");
                Console.WriteLine("3 - Вернуться в меню");
                ReadState(3);
                switch (State)
                {
                    case 1:
                        {
                            CreateVehicle(new Aircraft(), "Добавление самолета");
                        } break;
                    case 2:
                        {
                            CreateVehicle( new Helicopter(), "Добавление вертолета");
                        } break;
                    case 3:
                        {
                            return;
                        } break;
                    default:
                        {
                            Console.WriteLine("Ошибка при добавлении нового транспортного средства");
                        } break;
                }
            }
            while (true);
        }
    }
}
