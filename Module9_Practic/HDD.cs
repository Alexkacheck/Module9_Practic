using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9_Practic
{
    class HDD : Storage
    {
        // Приватные поля для хранения характеристик съемного HDD
        private double usbSpeed;         // Скорость USB 2.0
        private int partitions;          // Количество разделов на HDD
        private double partitionSize;    // Размер каждого раздела

        // Конструктор класса HDD
        public HDD(string name, string model, double usbSpeed, int partitions, double partitionSize)
            : base(name, model)  // Вызов конструктора базового класса с указанием имени и модели
        {
            // Инициализация полей объекта HDD
            this.usbSpeed = usbSpeed;
            this.partitions = partitions;
            this.partitionSize = partitionSize;
        }

        // Реализация абстрактного метода GetMemory
        public override double GetMemory()
        {
            // Возвращает общий объем памяти на HDD, умножая количество разделов на размер каждого раздела
            return partitions * partitionSize;
        }

        // Реализация абстрактного метода CopyData
        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Копирование {dataSize} ГБ данных на жесткий дискe...");
            // Здесь обычно реализуется операция копирования данных на съемный HDD
        }

        // Реализация абстрактного метода GetFreeMemory
        public override double GetFreeMemory()
        {
            // Возвращает свободное место на HDD, предполагая, что разделы пусты
            return partitions * partitionSize;
        }

        // Реализация метода PrintInfo для вывода информации о съемном HDD
        public override void PrintInfo()
        {
            Console.WriteLine($"HDD: {name} ({model}), USB 2.0 Speed: {usbSpeed} МБ/с, Разделы: {partitions}, Размер раздела: {partitionSize} GB");
        }
    }

}
