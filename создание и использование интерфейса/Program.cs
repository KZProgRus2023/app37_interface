using System;
namespace app37_interface
{
    interface ICar
    {
        int Speed { get; set; }
        void GetInfo();
    }
    interface IPrice
    {
        double Price();
    }
    public class Ferrari : ICar, IPrice
    {
        private int spd; // скорость (поле)
        public int Speed // скорость (свойство)
        {
            get { return spd; }
            set { spd = value; }
        }
        // Конкретная реализация интерфейса в классе:
        public void GetInfo()
        {
            Speed = 250;
            Console.WriteLine("Это суперкар Ferrari @ +
            "с макс. скоростью {0}", Speed);
        }
        // Конкретная реализация интерфейса в классе:
        public double IPrice()
        {
            Console.WriteLine("\nЦена автомобиля 20000");
        }
    }
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Создание и применение " +
            "интерфейса");
            Ferrari fr = new Ferrari();
            fr.GetInfo();
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}