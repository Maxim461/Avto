using System;
using Avto;

class Program
{
    static void Main()
    {
        Auto CarOne = new Auto("Car1", 50, 10);
        Auto CarTwo = new Auto("Car2", 50, 10);
        
        Auto ChoosingCar = null;
        while (true)
        {
            if (ChoosingCar == null)
            {
                Console.WriteLine("Выберите машину (1 или 2)");
                int ChoosingCarIfElse = int.Parse(Console.ReadLine());
                if (ChoosingCarIfElse == 0)
                {
                    break;  
                }
                else if (ChoosingCarIfElse == 1)
                    {
                        ChoosingCar = CarOne;
                    }
                    else if (ChoosingCarIfElse == 2)
                    {
                        ChoosingCar = CarTwo;
                    }
                    else
                    {
                        Console.WriteLine("Вы не правильно выбрали машину.\nВведите 1 или 2.");
                    }
                }
                Console.WriteLine("1 - Вывод информации;");
                Console.WriteLine("2 - Заправка топливом;");
                Console.WriteLine("3 - Ехать;");
                Console.WriteLine("4 - Ускориться;");
                Console.WriteLine("5 - Затормозить;");
                Console.WriteLine("6 - Смена машины.");
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
                        
                        Console.WriteLine("Введите скорость движения (км/ч):");
                        int Speed = int.Parse(Console.ReadLine());
                        if (Speed > 100)
                        {
                            Speed = 100;
                            Console.WriteLine("Скорость не может быть больше 100, скорость максимальная ");
                        }
                        if (Speed <= 0)
                        {
                            Speed = 10;
                            Console.WriteLine("Скорость не может быть меньше или равно 0");
                            Console.WriteLine("Установленная скорость 10");
                        }
                        Console.WriteLine("Введите расстояние (км):");
                        int DistanceUser = int.Parse(Console.ReadLine());
                        
                        if (DistanceUser <= 0)
                        {
                            DistanceUser = 1000;
                            Console.WriteLine("Расстояние не может быть меньше или равно 0");
                            Console.WriteLine("Установленное расстояние 1000");
                        }
                        Console.WriteLine($"Расстояние которое вам нужно проехать: {DistanceUser:f0}");
                        
                        ChoosingCar.Riding(Speed, DistanceUser);
                        
                        break;
                    case 4:

                        ChoosingCar.SpeedUp();
                        break;
                    case 5:
                        ChoosingCar.Braking();
                        break;
                    case 6:
                        ChoosingCar = null; 
                        break;
                }
            }
        }
    }