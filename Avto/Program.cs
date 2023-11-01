using Avto;

class Program
{
    static void Main()
    {
        Auto Untitled = new Auto(0, 0, 0, 0, 0); //Создание объекта на основе класса

        Untitled.ToBegin();

        Console.WriteLine("Нажмите 1 чтобы поехать");
        Console.WriteLine("Нажмите 2 чтобы ускориться");
        Console.WriteLine("Нажмите 3 чтобы затормозить");
        Console.WriteLine("Нажмите 4 чтобы запрвиться");
        Console.WriteLine("Нажмите 5 чтобы посмотреть информацию");
        Console.WriteLine("Нажмите 6 чтобы прошел час");

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.D1:
                Untitled.Drive(); //Поехать
                break;

                case ConsoleKey.D2:
                Untitled.SpeedUp();     //Ускорение
                break;
                    
                case ConsoleKey.D3:
                Untitled.SlowDown(); //Затормозить
                break;

                case ConsoleKey.D4:
                Untitled.Refuel(); // Заправиться
                break;

                case ConsoleKey.D5:
                Untitled.Information(); //Информация
                break;

                case ConsoleKey.D6:
                Untitled.Hour(); //Час
                break;
            }
        }
    }
}