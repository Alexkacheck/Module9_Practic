using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9_Practic
{
    abstract class Storage
    {
        // Защищенные поля для хранения общих характеристик всех носителей информации
        protected string name;  // Наименование носителя
        protected string model; // Модель носителя

        // Конструктор абстрактного класса Storage
        public Storage(string name, string model)
        {
            this.name = name;
            this.model = model;
        }

        // Абстрактный метод для получения объема памяти носителя
        public abstract double GetMemory();

        // Абстрактный метод для копирования данных на носитель
        public abstract void CopyData(double dataSize);

        // Абстрактный метод для получения информации о свободном объеме памяти на носителе
        public abstract double GetFreeMemory();

        // Абстрактный метод для вывода информации о носителе
        public abstract void PrintInfo();
    }
}

