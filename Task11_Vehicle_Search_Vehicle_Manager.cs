using System.Collections;

namespace CSharp_Practice
{
    public class VehicleManager
    {
        public static void SearchACar(string searchCarNumber, List<Vehicle> cars)
        {
            int vehicleWithoutOwner = 0;
            bool carFound = false;
            foreach (var car in cars)
            {
                if (car.Owner == "")
                {
                    vehicleWithoutOwner++;
                }
            }
            foreach (var car in cars)
            {
                if (searchCarNumber == car.LicensePlate && car.Owner != null)
                {
                    Console.WriteLine($"Транспортное средство найдено: {searchCarNumber}, владелец: {car.Owner}");
                    carFound = true;
                    break;
                }
            }

            if (!carFound)
            {
                throw new Exception($"транспортное средство с номером {searchCarNumber} не найдено ");
            }
            Console.WriteLine($"Количество транспортных средств без владельца: {vehicleWithoutOwner}");
        }
    }
}


//Поиск транспортного средства по номеру.
//Подсчёт транспортных средств без указанного владельца.
//Исключение, если транспортное средство не найдено.
//Классы:


//Вывод:
//Транспортное средство найдено: ABC123, владелец: Иван
//Количество транспортных средств без владельца: 1