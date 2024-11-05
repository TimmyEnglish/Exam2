using Exam2;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Створюємо об'єкт HardDrive
        HardDrive hd = new HardDrive(500);

        // Створюємо об'єкт Computer
        Computer computer = new Computer(hd, "Dell", 15000m);
        computer.PrintInfo();

        Console.WriteLine();

        // Створюємо об'єкт ComputerWithMonitor
        ComputerWithMonitor computerWithMonitor = new ComputerWithMonitor(hd, "HP", 20000m, 27);
        computerWithMonitor.PrintInfo();
        Console.ReadLine();
    }
}
