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
            Console.WriteLine($"Количество бензина в баке: {NumberGasoline};");
        }

        public void Riding()
        {
            Console.WriteLine("С какой скоростю вы хотите ехать?");
            Speed = double.Parse(Console.ReadLine());

            Console.WriteLine($"Какое расстояние вы хотите проехать на скорости {Speed}?");
            DistanceUser = double.Parse(Console.ReadLine());

            Setting();
            Kilometers += DistanceUser;
            Console.WriteLine($"Количество бензина в баке: {NumberGasoline};");
            Console.WriteLine($"Вы проехали: {Kilometers};");
        }

        public void SpeedUp()
        {
            Console.WriteLine("На сколько вы хотите ускориться?");
            Speed = +double.Parse(Console.ReadLine());
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