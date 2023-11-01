using System;

namespace Avto
{
	public class Auto
	{
        private int Speed;
        private int Petrol;
        private int PetrolUser;
        private int Distance;

        public Auto(int Speed, int Petrol, int PetrolUser, int Distance, int HourVar)
		{
            this.Speed = Speed;
            this.Petrol = Petrol;
            this.PetrolUser = PetrolUser;
            this.Distance = Distance;
        }

        public void ToBegin()
        {
            Random rnd = new Random();
            Distance = rnd.Next(1000);
            Petrol = 100;
        }

		public void Drive()
        {
            Speed = 50;
            Console.WriteLine($"Скорость: {Speed}");
        }

        public void SpeedUp()
        {
            Speed = Speed + 10;
            Console.WriteLine($"Скорость: {Speed}");
        }

        public void SlowDown()
        {
            Speed = 0;
            Console.WriteLine($"Скорость: {Speed}");
        }

        public void Refuel()
        {
            Console.WriteLine("Введите количество бензина: ");
            PetrolUser = int.Parse(Console.ReadLine());
            Petrol = PetrolUser + Petrol;
            if (Petrol > 100)
            {
                Console.WriteLine("Ваш бак переполнен!!!");
            }
        }

        public void Information()
        {
            Distance = (Distance - (Distance % 10));
            Console.WriteLine($"Остаток бензина: {Petrol}");
            Console.WriteLine($"Растояние которое нужно проехать: {Distance}");
        }

        public void Hour()
        {
            if (Speed == 50)
            {
                Distance = Distance - Speed;
                Petrol = Petrol - 10;
            }
            else if (Speed == 60)
            {
                Distance = Distance - Speed;
                Petrol = Petrol - 12;
            }
            else if (Speed == 70)
            {
                Distance = Distance - Speed;
                Petrol = Petrol - 14;
            }
            else if (Speed == 80)
            {
                Distance = Distance - Speed;
                Petrol = Petrol - 16;
            }
            else if (Speed == 90)
            {
                Distance = Distance - Speed;
                Petrol = Petrol - 18;
            }
            else if (Speed == 100)
            {
                Distance = Distance - Speed;
                Petrol = Petrol - 20;
            }
            else
            {
                Console.WriteLine("Вы превысили максимальную скорость.");
            }
            Console.WriteLine("Прошел один час, посмотрите информацию");
        }
    }
}