using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework17_2
{

    public class Car
    {
       public string marka;
       public string model;
       public int year;
       public string color;
    }

    public class CarOwner
    {
        public string name;
        public string phone;
        public Car car;
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;

            var cars = new List<Car>()
            {
                new Car()
                {
                    marka = "Opel",
                    model = "Insignia",
                    year = 2020,
                    color = "grey"
                },
                new Car()
                {
                    marka = "Nissan",
                    model = "Leaf",
                    year = 2014,
                    color = "white"
                },
                new Car()
                {
                    marka = "Shkoda",
                    model = "Rapid",
                    year = 2012,
                    color = "black"
                }
            };

            var owners = new List<CarOwner>()
            {
                new CarOwner()
                {
                    name = "Andriy",
                    phone = "0670202022",
                    car = cars[0]
                },
                new CarOwner()
                {
                    name = "Sergiy",
                    phone = "067030303",
                    car = cars[1]
                },
                new CarOwner()
                {
                    name = "Don Pedro",
                    phone = "067040404",
                   car = cars[2]
                }
            };


            var query = from owner in owners
                        where owner.name == "Don Pedro"
                        orderby owner.name
                        select new
                        {
                            name = owner.name,
                            phone = owner.phone,
                            car = owner.car
                        };



            /*Використовуючи найпростіший запит LINQ, виведіть на екран інформацію про покупця одного з автомобілів і повну характеристику придбаної ним моделі. */

            foreach (var owner in query)
            {
                Console.WriteLine($"Owner name: {owner.name} \n Owner phone: {owner.phone} \n " +
                    $"Car info: " +
                    $"\n\t Marka: {owner.car.marka}" +
                    $"\n\t Model: {owner.car.model}" +
                    $"\n\t Year: {owner.car.year}" +
                    $"\n\t Color: {owner.car.color}");
            }

            Console.ReadKey();
        }
    }
}
