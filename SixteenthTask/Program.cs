using System;

namespace SixteenthTask
{
    public class Vehicle
    {
        public string model;
        public string manufacturer;
        public int numOfDoors;
        public int numOfWheels;
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите информацию о машине");
            Vehicle myCar = new Vehicle();
            Console.Write("Модель -");
            string s = Console.ReadLine();
            myCar.model = s;
            Console.Write("Производитель -");
            myCar.manufacturer = Console.ReadLine();
            Console.Write("Кол-во дверей =");
            s = Console.ReadLine();
            myCar.numOfDoors = Convert.ToInt32(s);
            Console.Write("Кол-во колёс =");
            s = Console.ReadLine();
            myCar.numOfWheels = Convert.ToInt32(s);
            Console.WriteLine("\nВаша машина: ");
            Console.WriteLine(myCar.manufacturer + " " + myCar.model);
            Console.WriteLine("С " + myCar.numOfDoors + " дверями " + " на " + myCar.numOfWheels + " колёсах ");
            Console.WriteLine("Нажмите <Enter> для завершения программы . . . ");
            Console.Read();
        }
    }
}
