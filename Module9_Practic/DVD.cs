using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9_Practic
{
    class DVD : Storage
    {
        // Приватные поля для хранения характеристик DVD-диска
        private double readSpeed;    // Скорость чтения
        private double writeSpeed;   // Скорость записи
        private string type;         // Тип DVD (односторонний / двусторонний)

        // Конструктор класса DVD
        public DVD(string name, string model, double readSpeed, double writeSpeed, string type)
            : base(name, model)  // Вызов конструктора базового класса с указанием имени и модели
        {
            // Инициализация полей объекта DVD
            this.readSpeed = readSpeed;
            this.writeSpeed = writeSpeed;
            this.type = type;
        }

        // Реализация абстрактного метода GetMemory
        public override double GetMemory()
        {
            // Возвращает объем памяти DVD в зависимости от его типа
            return type == "Односторонний" ? 4.7 : 9.0;
        }

        // Реализация абстрактного метода CopyData
        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Копирование {dataSize} Односторонний перенос данных на DVD...");
            // Здесь обычно реализуется операция копирования данных на DVD-диск
        }

        // Реализация абстрактного метода GetFreeMemory
        public override double GetFreeMemory()
        {
            // Возвращает свободное место на DVD, предполагая, что диск пуст
            return GetMemory(); // Предположим, что весь диск пуст
        }

        // Реализация метода PrintInfo для вывода информации о DVD-диске
        public override void PrintInfo()
        {
            Console.WriteLine($"DVD: {name} ({model}), Read Speed: {readSpeed} MB/s, Write Speed: {writeSpeed} MB/s, Type: {type}");
        }
    }
}
