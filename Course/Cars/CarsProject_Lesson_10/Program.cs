using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarClass;

namespace Lesson_10
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = Encoding.UTF8;
            ConsoleKeyInfo pressedKey;

            bool flag = true;
            int carCount = 0;

            while (flag)
            {
                Console.Write("Введите модель машины: ");
                string modele = Console.ReadLine().Trim();

                Console.Write("Введите цвет машины: ");
                string color = Console.ReadLine().Trim();

                string priceStr;
                int price;

                do
                {
                    Console.Write("Введите цену машины: ");
                    priceStr = Console.ReadLine();
                // isPriceOk = !int.TryParse(priceStr, out price);
                   // while (isPriceOk)
               } while (!int.TryParse(priceStr, out price)); // cтарайся писать один оператор в одном лайне Func1(Func2(Func3(a))) плохо читается
 

                Car car = new Car(modele, color, price);
                CarsKeeper.AddCar(car);
                carCount++;

                Console.WriteLine($"Название автомобиля: {car.Modele}, Цвет автомобиля: {car.Color}, Цена автомобиля: {car.Price}$, Текущая скидка на автомобиль: {car.Discount}%");

                Console.WriteLine("Желаете получить случайную скидку? Нажмите \"Y\" - ДА, \"N\" - НЕТ.");
                pressedKey = Console.ReadKey(true);

                switch (pressedKey.Key.ToString())
                {
                    case "Y":
                        car.SetDiscount(car);
                        Console.WriteLine($"Название автомобиля: {car.Modele}, Цвет автомобиля: {car.Color}, Цена автомобиля: {car.Price}$, Текущая скидка на автомобиль: {car.Discount}%");
                        break;

                    case "N":
                        break;
                        
                        // всегда добавляй default хорошая практика
                }

                if (carCount >= 3) // магические числа в коде выноси это в отдельную переменую с самодокументируемым названием
                {
                    Console.WriteLine("Лимит в магазине - 3 машины.");
                    break;
                }
            }

            Console.WriteLine("Желаете просмотреть все автомобили? Нажмите \"Y\" - ДА, \"N\" - НЕТ.");
            pressedKey = Console.ReadKey(true);

            switch (pressedKey.Key.ToString())
            {
                case "Y":
                    var savedCars = CarsKeeper.GetCars;

                    foreach (Car myCar in savedCars)
                    {
                        Console.WriteLine($"Название автомобиля: {myCar.Modele}, Цвет автомобиля: {myCar.Color}, Цена автомобиля: {myCar.Price}$, Текущая скидка на автомобиль: {myCar.Discount}%");
                       // попрбуй еще string.Format для вывода строк чисто для расширения кругозора
                    }
                    break;

                case "N":
                    break;
                    
                    
            }

            Console.ReadKey();

        }
    }
}
