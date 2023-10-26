using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9_Practic
{
    class Flash : Storage
    {
        // Приватные поля для хранения характеристик Flash-памяти
        private double usbSpeed;   // Скорость USB 3.0
        private double memory;     // Объем памяти

        // Конструктор класса Flash
        public Flash(string name, string model, double usbSpeed, double memory)
            : base(name, model)  // Вызов конструктора базового класса с указанием имени и модели
        {
            // Инициализация полей объекта Flash
            this.usbSpeed = usbSpeed;
            this.memory = memory;
        }

        // Реализация абстрактного метода GetMemory
        public override double GetMemory()
        {
            // Возвращает общий объем памяти Flash-памяти
            return memory;
        }

        // Реализация абстрактного метода CopyData
        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Копирование {dataSize} ГБ данных на флэш-накопитель...");
            // Здесь обычно реализуется операция копирования данных на Flash-память
        }

        // Реализация абстрактного метода GetFreeMemory
        public override double GetFreeMemory()
        {
            // Возвращает свободное место на Flash-памяти, предполагая, что память пуста
            return memory;
        }

        // Реализация метода PrintInfo для вывода информации о Flash-памяти
        public override void PrintInfo()
        {
            Console.WriteLine($"Flash Drive: {name} ({model}), USB 3.0 Speed: {usbSpeed} MB/s, Memory: {memory} GB");
        }
    }

}
