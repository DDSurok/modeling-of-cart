using System;
using System.Drawing;

namespace Телега.Графические_объекты
{
    class Точка : Графический_объект
    {
        public Color Цвет { get; set; }
        public double X, Y;
        private Область_построения Родитель;
        public Точка (Область_построения родитель, double x, double y, Color цвет)
        {
            this.X = x;
            this.Y = y;
            this.Цвет = цвет;
            this.Родитель = родитель;
        }
        public virtual void Повернуть(double x, double y)
        {
            double tempx = (this.X - x) * Math.Cos(this.Родитель.параметры.Приращение_угла) - (this.Y - y) * Math.Sin(this.Родитель.параметры.Приращение_угла) + x;
            double tempy = (this.X - x) * Math.Sin(this.Родитель.параметры.Приращение_угла) + (this.Y - y) * Math.Cos(this.Родитель.параметры.Приращение_угла) + y;
            this.X = tempx;
            this.Y = tempy;
        }
        public virtual void Нарисовать(ref Graphics gr)
        {
        }
        public static double Расстояние_между_двумя_точками(Точка точка1, Точка точка2)
        {
            return Math.Sqrt(Math.Pow(точка1.X - точка2.X, 2) + Math.Pow(точка1.Y - точка2.Y, 2));
        }
    }
}
