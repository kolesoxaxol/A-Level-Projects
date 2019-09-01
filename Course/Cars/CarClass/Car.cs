using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    public class Car
    {
        public string Modele { get; private set; }
        public string Color { get; private set; }
        public int Price { get; set; }
        public int Discount { get; private set; }

        private int _discount = 0;

        Random rnd = new Random();

        public Car(string modele, string color, int price)
        {
            this.Modele = modele;
            this.Color = color;
            this.Price = price;
            this.Discount = _discount;
        }

        public void SetDiscount(Car car)
        {
            int discount = rnd.Next(10, 90);
            car.Discount = discount;

            int price = car.Price;
            int newCarPrice = price - (price / 100 * discount);

            car.Price = newCarPrice;
        }
    }
}
