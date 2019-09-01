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

                } while (!int.TryParse(priceStr, out price));

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
                }

                if (carCount >= 3)
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
                    }
                    break;

                case "N":
                    break;
            }

            Console.ReadKey();

        }
    }
}