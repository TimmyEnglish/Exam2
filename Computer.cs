using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    public class Computer
    {
        public HardDrive HardDrive { get; set; } // Об'єкт класу HardDrive
        public string Brand { get; set; }        // Марка комп'ютера
        public decimal Price { get; set; }       // Ціна комп'ютера

        // Конструктор
        public Computer(HardDrive hardDrive, string brand, decimal price)
        {
            HardDrive = hardDrive;
            Brand = brand;
            Price = price;
        }

        // Метод для друку інформації про комп'ютер
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Марка: {Brand}, Ціна: {Price} грн, Обсяг жорсткого диска: {HardDrive.GetCapacity()} ГБ");
        }
    }

}
