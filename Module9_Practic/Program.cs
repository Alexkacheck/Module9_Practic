using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9_Practic
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Storage> storageDevices = new List<Storage>
        {
            new Flash("FlashDrive1", "Kingston", 100, 64),
            new DVD("DVD1", "Verbatim", 21, 8, "Односторонний"),
            new HDD("HDD1", "Seagate", 480, 2, 500)
        };

            // Расчет общего объема памяти всех устройств
            double totalMemory = storageDevices.Sum(device => device.GetMemory());
            Console.WriteLine($"Общая память всех устройств: {totalMemory} GB");

            // Расчет времени, необходимого для копирования
            double dataSizeToCopy = 565; // Размер данных в GB
            double copyTime = dataSizeToCopy / storageDevices[0].GetMemory(); // Предполагаем копирование на Flash-память

            Console.WriteLine($"Время, необходимое для копирования данных: {copyTime} hours");

            // Расчет необходимого количества носителей информации
            int requiredDevices = (int)Math.Ceiling(dataSizeToCopy / storageDevices[0].GetMemory());
            Console.WriteLine($"Требуемое количество запоминающих устройств: {requiredDevices}");

            // Вывод информации о всех устройствах
            foreach (var device in storageDevices)
            {
                device.PrintInfo();
            }
        }
    }
    }

