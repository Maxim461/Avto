using System;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace Avto
{
    public class Auto
    {
        string NumberCar;
        double NumberGasoline;
        double Fuel_Сonsumption;
        double Kilometers;
        double Speed;
        double DistanceUser;


        public Auto(string nom, double bak, double ras)
        {
            this.NumberCar = nom;
            this.NumberGasoline = bak;
            this.Fuel_Сonsumption = ras;
            this.Kilometers = 0.0;
            this.Speed = 0.0;

        }

        public void InformationOutput()
        {
            Console.WriteLine($"Номер авто: {NumberCar};");
            Console.WriteLine($"Количество бензина в баке: {NumberGasoline};");
            Console.WriteLine($"Расход топлива на 100 км: {Fuel_Сonsumption};");
            Console.WriteLine($"Вы проехали: {Kilometers};");
            Console.WriteLine($"Текущая скорость: {Speed} км/ч;");
        }

        public void Refueling()
        {
            Console.WriteLine("Введите количетсво бензина:");
            double top = double.Parse(Console.ReadLine());
            NumberGasoline = NumberGasoline + top;
            if (NumberGasoline > 50)
            {
                Console.WriteLine("Бак не может быть больше 50");
            }
            
            Console.WriteLine($"Количество бензина в баке: {NumberGasoline};");
        }

        public void Riding(double Speed, int distance)
        {
            if (Speed <= 0)
            {
                Console.WriteLine("Скорость должна быть больше нуля.");
                return;
            }
            double FuelConsumptionPer100Km = Fuel_Сonsumption / 100;
            double Consumption = distance * FuelConsumptionPer100Km;
            if (NumberGasoline >= Consumption)
            {
                NumberGasoline -= Consumption;
                Kilometers += distance;
                Console.WriteLine("Вы приехали");
                
            }
            else
            {
                int MaxDistance = (int)(NumberGasoline / FuelConsumptionPer100Km);
                if (MaxDistance > 0)
                {
                    NumberGasoline = 0;
                    Console.WriteLine($"Недостаточно топлива для поездки на всю дистанцию {distance} км.");
                    Console.WriteLine($"Машина проехала {MaxDistance} км со скоростью {Speed} км/ч.\nКоличество бензина: {NumberGasoline}");
                    Kilometers += MaxDistance;

                    Console.Write("Желаете дозаправить машину? (Да/Нет): ");
                    string choice = Console.ReadLine();

                    if (choice.ToLower() == "да")
                    {
                        Refueling();
                        Riding(Speed, distance - MaxDistance);
                    }
                    else
                    {
                        Console.WriteLine("Ну и не надо...");
                        
                    }
                }
                else
                {
                    Console.WriteLine("Недостаточно топлива для поездки.");
                }
            }
        }

        public void SpeedUp()
        {
            Console.WriteLine("На сколько вы хотите ускориться?");
            Speed =+ double.Parse(Console.ReadLine());
            Kilometers += DistanceUser;
            Setting();

            Console.WriteLine($"Количество бензина в баке: {NumberGasoline};");
            Console.WriteLine($"Вы проехали: {Kilometers};");
        }

        public void Braking()
        {
            Speed = 0;
        }

        public void Setting()
        {
            if (Speed < 25)
            {
                NumberGasoline = NumberGasoline - (Fuel_Сonsumption * (DistanceUser / 100));
            }
            else if (Speed < 50 && Speed > 25)
            {
                NumberGasoline = NumberGasoline - ((Fuel_Сonsumption + 5) * (DistanceUser / 100));

            }
            else if (Speed < 100 && Speed > 50)
            {
                NumberGasoline = NumberGasoline - ((Fuel_Сonsumption + 10) * (DistanceUser / 100));
            }
            else
            {
                Console.WriteLine("Вы не можете ехать больше 100 км/ч");
            }
        }
    }
}