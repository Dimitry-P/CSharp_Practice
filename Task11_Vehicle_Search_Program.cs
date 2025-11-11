using System.Collections;

namespace CSharp_Practice
{
    class Program()
    {

        public static void Main()
        {
            var cars = new List<Vehicle>();
            Console.WriteLine("Введите кол-во имеющихся машин:");
            int carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                Console.WriteLine($"Введите Номер {i + 1}-ой машины:");
                string carNumber = Console.ReadLine();

                Console.WriteLine("Введите владельца машины:");
                string nameOfOwner = Console.ReadLine();
                cars.Add(new Vehicle(carNumber, nameOfOwner));
            }
            Console.WriteLine("Введите номер транспортного средства, которое вы хотите найти:");
            string searchCarNumber = Console.ReadLine();
            VehicleManager.SearchACar(searchCarNumber, cars);
        }
    }
}

//Задача 4: Управление транспортными средствами
//Описание:
//Создайте класс VehicleManager, который хранит список транспортных средств. Реализуйте:

//Поиск транспортного средства по номеру.
//Подсчёт транспортных средств без указанного владельца.
//Исключение, если транспортное средство не найдено.
//Классы:

//Vehicle – класс с полями: licensePlate(String), owner(String).
//VehicleManager – менеджер транспортных средств.
//Пример ввода:
//Транспортные средства:
//[Vehicle("ABC123", "Иван"), Vehicle("XYZ789", null), Vehicle("LMN456", "Анна")]

//Вывод:
//Транспортное средство найдено: ABC123, владелец: Иван
//Количество транспортных средств без владельца: 1