using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    public class HardDrive
    {
        private int _capacity; // Обсяг у гігабайтах

        // Конструктор
        public HardDrive(int capacity)
        {
            _capacity = capacity;
        }

        // Метод доступу до обсягу
        public int GetCapacity()
        {
            return _capacity;
        }
    }

}
