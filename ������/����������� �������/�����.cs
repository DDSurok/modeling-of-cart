using System;
using System.Drawing;

namespace Телега.Графические_объекты
{
    class Точка : Графический_объект
    {
        public Color Цвет;
        public double X, Y;
        public Точка (double x, double y, Color цвет)
        {
            this.X = x;
            this.Y = y;
            this.Цвет = цвет;
        }
        public virtual void Повернуть(double x, double y)
        {
            double tempx = (this.X - x) * Math.Cos(Параметры.Приращение_угла) - (this.Y - y) * Math.Sin(Параметры.Приращение_угла) + x;
            double tempy = (this.X - x) * Math.Sin(Параметры.Приращение_угла) + (this.Y - y) * Math.Cos(Параметры.Приращение_угла) + y;
            this.X = tempx;
            this.Y = tempy;
        }
        public virtual void Нарисовать(ref Graphics gr)
        {
        }
    }
}
