using System;
using System.Collections.Generic;
using System.Linq;

namespace LAB_4_Kukurik
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public double Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Equipment> Equipments = new List<Equipment>
            {
                new Equipment { Id = 1, Name = "Нагрівач", Status = "Активний", Price = 1200 },
                new Equipment { Id = 2, Name = "Труба", Status = "Архівний", Price = 20 },
                new Equipment { Id = 3, Name = "Інфрачервоний датчик", Status = "Активний", Price = 200 },
                new Equipment { Id = 4, Name = "Теплообмінник", Status = "Активний", Price = 800 },
                new Equipment { Id = 5, Name = "Контролер температури", Status = "Архівний", Price = 50 },
                new Equipment { Id = 6, Name = "Термопара", Status = "Активний", Price = 15 },
                new Equipment { Id = 7, Name = "Піч", Status = "Активний", Price = 1500 },
                new Equipment { Id = 8, Name = "Вентилятор", Status = "Архівний", Price = 80 },
                new Equipment { Id = 9, Name = "Тепловий насос", Status = "Активний", Price = 3000 },
                new Equipment { Id = 10, Name = "Датчик тиску", Status = "Активний", Price = 300 },
                new Equipment { Id = 11, Name = "Терморегулятор", Status = "Архівний", Price = 35 },
                new Equipment { Id = 12, Name = "Котел", Status = "Активний", Price = 2500 },
                new Equipment { Id = 13, Name = "Сонячний колектор", Status = "Активний", Price = 1200 },
                new Equipment { Id = 14, Name = "Теплова завіса", Status = "Архівний", Price = 400 },
                new Equipment { Id = 15, Name = "Теплоізоляція", Status = "Активний", Price = 150 },
                new Equipment { Id = 16, Name = "Кондиціонер", Status = "Архівний", Price = 600 },
                new Equipment { Id = 17, Name = "Теплогенератор", Status = "Активний", Price = 5000 },
                new Equipment { Id = 18, Name = "Термопомпа", Status = "Активний", Price = 1200 },
                new Equipment { Id = 19, Name = "Датчик температури", Status = "Активний", Price = 70 },
                new Equipment { Id = 20, Name = "Система вентиляції", Status = "Архівний", Price = 1800 },
                new Equipment { Id = 21, Name = "Електронагрівач", Status = "Активний", Price = 900 },
                new Equipment { Id = 22, Name = "Індукційний котел", Status = "Архівний", Price = 450 },
                new Equipment { Id = 23, Name = "Термостат", Status = "Активний", Price = 50 },
                new Equipment { Id = 24, Name = "Газовий пальник", Status = "Активний", Price = 350 },
                new Equipment { Id = 25, Name = "Тепловий лічильник", Status = "Архівний", Price = 700 },
                new Equipment { Id = 26, Name = "Панель управління", Status = "Активний", Price = 120 },
                new Equipment { Id = 27, Name = "Водонагрівач", Status = "Архівний", Price = 200 },
                new Equipment { Id = 28, Name = "Автоматичний вентиль", Status = "Активний", Price = 500 },
                new Equipment { Id = 29, Name = "Тепловий акумулятор", Status = "Активний", Price = 250 },
                new Equipment { Id = 30, Name = "Сервопривід", Status = "Архівний", Price = 150 }
            };

            // 10.Порахувати кількість обладнання, ціна яких перевищує 500.
            var equipmentCountAbove500 = Equipments.Count(e => e.Price > 500);
            Console.WriteLine("10)Кількість обладнання, ціна яких більше 500: " + equipmentCountAbove500);
            Console.WriteLine("\n");

            // 11.Вибрати перші 5 обладнання у списку.
            var firstFiveEquipments = Equipments.Take(5).ToList();
            Console.WriteLine("11)Перші 5 одиниць обладнання:");
            firstFiveEquipments.ForEach(e => Console.WriteLine(e.Name));
            Console.WriteLine("\n");

            // 12.Повернути останнє обладнання у списку.
            var lastEquipment = Equipments.LastOrDefault();
            Console.WriteLine("12)Останнє обладнання у списку: " + (lastEquipment != null ? lastEquipment.Name : "Відсутнє"));
            Console.WriteLine("\n");

            // 13.Вибрати всі обладнання зі статусом "Архівний" і відсортувати їх за ціною у порядку зростання.
            var archivedAndSortedEquipments = Equipments.Where(e => e.Status == "Архівний").OrderBy(e => e.Price).ToList();
            Console.WriteLine("13)Архівне обладнання, відсортоване за ціною:");
            archivedAndSortedEquipments.ForEach(e => Console.WriteLine($"{e.Name} - {e.Price}"));
            Console.WriteLine("\n");

            // 14.Повернути назви обладнання у верхньому регістрі.
            var equipmentNamesUppercase = Equipments.Select(e => e.Name.ToUpper()).ToList();
            Console.WriteLine("14)Назви обладнання у верхньому регістрі:");
            equipmentNamesUppercase.ForEach(name => Console.WriteLine(name));
            Console.WriteLine("\n");

            // 15.Вибрати обладнання, ціна яких знаходиться у діапазоні від 100 до 1000.
            var equipmentInRange = Equipments.Where(e => e.Price >= 100 && e.Price <= 1000).ToList();
            Console.WriteLine("15)Обладнання з ціною від 100 до 1000:");
            equipmentInRange.ForEach(e => Console.WriteLine($"{e.Name} - {e.Price}"));
            Console.WriteLine("\n");

            // 16.Знайти обладнання з найменшою ціною.
            var cheapestEquipment = Equipments.OrderBy(e => e.Price).FirstOrDefault();
            Console.WriteLine("16)Обладнання з найменшою ціною: " + (cheapestEquipment != null ? cheapestEquipment.Name : "Відсутнє"));
            Console.WriteLine("\n");

            // 17.Вибрати всі обладнання, назви яких містять слово "Датчик".
            var equipmentWithSensorInName = Equipments.Where(e => e.Name.Contains("Датчик")).ToList();
            Console.WriteLine("17)Обладнання з назвою, що містить 'Датчик':");
            equipmentWithSensorInName.ForEach(e => Console.WriteLine(e.Name));
            Console.WriteLine("\n");

            // 18.Підрахувати загальну кількість обладнання в системі.
            var totalEquipmentCount = Equipments.Count();
            Console.WriteLine("18)Загальна кількість обладнання: " + totalEquipmentCount);
            Console.WriteLine("\n");

            // 19.Знайти обладнання з найменшим ідентифікатором.
            var equipmentWithSmallestId = Equipments.OrderBy(e => e.Id).FirstOrDefault();
            Console.WriteLine("19)Обладнання з найменшим ідентифікатором: " + (equipmentWithSmallestId != null ? equipmentWithSmallestId.Name : "Відсутнє"));
            Console.WriteLine("\n");

            // 20.Вибрати обладнання, назви яких складаються з одного слова.
            var singleWordNames = Equipments.Where(e => !e.Name.Contains(" ")).ToList();
            Console.WriteLine("20)Обладнання з назвами з одного слова:");
            singleWordNames.ForEach(e => Console.WriteLine(e.Name));

        }
    }
}