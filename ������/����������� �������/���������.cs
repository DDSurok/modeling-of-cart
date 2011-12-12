using System;
using System.Drawing;

namespace Телега.Графические_объекты
{
    public class Параметры
    {
        public Color Цвет_левого_колеса;
        public int Размер_левого_колеса;
        public Color Цвет_правого_колеса;
        public int Размер_правого_колеса;
        public Color Цвет_телеги;
        public int Длина_телеги;            // Расстояние между центрами колес
        public int Высота_телеги;
        public double Скорость_движения;    // В градусах
        public readonly int Смещение_по_Y;
        public Параметры()                  // Стандартные значения
        {
            this.Цвет_левого_колеса = Color.Red;
            this.Размер_левого_колеса = 25;
            this.Цвет_правого_колеса = Color.Red;
            this.Размер_правого_колеса = 50;
            this.Цвет_телеги = Color.Green;
            this.Длина_телеги = 100;
            this.Высота_телеги = 50;
            this.Скорость_движения = 1;
            this.Смещение_по_Y = 40;
        }
    }
}
