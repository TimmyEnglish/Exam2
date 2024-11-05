using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class PrivateComputerWithMonitor : Computer
    {
        private double MonitorSize { get; set; } // Розмір монітора в дюймах

        // Конструктор
        public PrivateComputerWithMonitor(HardDrive hardDrive, string brand, decimal price, double monitorSize)
            : base(hardDrive, brand, price)
        {
            MonitorSize = monitorSize;
        }

        // Перевизначений метод для друку інформації
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Розмір монітора: {MonitorSize} дюймів");
        }
    }

}
