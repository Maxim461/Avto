using System.Security.Cryptography;
using Avto;

class Program
{
    static void Main()
    {
        Auto CarOne = new Auto("Car1", 50, 10);
        Auto CarTwo = new Auto("Car2", 50, 10);
        Random random = new Random();
        double Distance = random.Next(100, 1000);
        Distance = (Distance / 10) * 100;
        Console.WriteLine($"Расстояние которое вам нужно проехать: {Distance:f0}");

        while (true)
        {
            Console.WriteLine("Выберите машину:");
            int  ChoosingCarIfElse =  int.Parse(Console.ReadLine());

            Auto ChoosingCar;

            if (ChoosingCarIfElse == 1)
            {
                ChoosingCar = CarOne;
            }
            else if (ChoosingCarIfElse == 2)
            {
                ChoosingCar = CarTwo;
            }
            else
            {
                Console.WriteLine("Вы не правильно выбрали машину.\nВведите 1 или 2, далее нажмите Enter.");
                continue;
            }

            Console.WriteLine("1 - Вывод информации;");
            Console.WriteLine("2 - Заправка топливом;");
            Console.WriteLine("3 - Ехать;");
            Console.WriteLine("4 - Ускориться;");
            Console.WriteLine("5 - Затормозить.");
            int ChoosingAnAction = int.Parse(Console.ReadLine());
            switch (ChoosingAnAction)
            {
                case 1:
                    ChoosingCar.InformationOutput();
                break;

                case 2:
                    ChoosingCar.Refueling();
                break;

                case 3:
                    ChoosingCar.Riding();
                break;

                case 4:
                    ChoosingCar.SpeedUp();
                break;

                case 5:
                    ChoosingCar.Braking();
                break;
            }
        }
    }
}