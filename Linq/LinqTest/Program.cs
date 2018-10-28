using System;
using System.Collections.Generic;

namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cheese> cheeses = new List<Cheese>();

            Cheese cheese = new Cheese
            {
                Name = "Гауда",
                ShelfLife = DateTime.Now.AddMonths(1),
                Type = TypeOfCheese.SemiSoft,
                Taste = "Такой себе"
            };

            cheeses.Add(cheese);

            cheese = new Cheese
            {
                Name = "Пармезан",
                ShelfLife = DateTime.Now.AddMonths(2),
                Type = TypeOfCheese.Hard,
                Taste = "Вкусный"
            };

            cheeses.Add(cheese);

            cheese = new Cheese
            {
                Name = "Российский",
                ShelfLife = DateTime.Now.AddDays(-3),
                Type = TypeOfCheese.SemiSoft,
                Taste = "Нормально"
            };

            cheeses.Add(cheese);

            cheese = new Cheese
            {
                Name = "Маскарпоне",
                ShelfLife = DateTime.Now.AddDays(2),
                Type = TypeOfCheese.Soft,
                Taste = "Вкусно в десертах"
            };

            cheeses.Add(cheese);
        }
    }

    class Cheese
    {
        public string Name { get; set; }
        public DateTime ShelfLife { get; set; }
        public TypeOfCheese Type { get; set; }
        public string Taste { get; set; }
    }

    enum TypeOfCheese
    {
        Soft,
        SemiSoft,
        MediumHard,
        Hard
    }
}
