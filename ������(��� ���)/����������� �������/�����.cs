using System;
using System.Drawing;

namespace Телега.Графические_объекты
{
    struct Точка
    {
        public Color Цвет;
        public double X, Y;
        public static void Установить_значения(ref Точка точка, double x, double y, Color цвет)
        {
            точка.X = x;
            точка.Y = y;
            точка.Цвет = цвет;
        }
        public static void Повернуть(ref Точка точка, Область_построения область_построения, double x, double y)
        {
            double tempx = (точка.X - x) * Math.Cos(область_построения.Приращение_угла) - (точка.Y - y) * Math.Sin(область_построения.Приращение_угла) + x;
            double tempy = (точка.X - x) * Math.Sin(область_построения.Приращение_угла) + (точка.Y - y) * Math.Cos(область_построения.Приращение_угла) + y;
            точка.X = tempx;
            точка.Y = tempy;
        }
        public static double Расстояние_между_двумя_точками(Точка точка1, Точка точка2)
        {
            return Math.Sqrt(Math.Pow(точка1.X - точка2.X, 2) + Math.Pow(точка1.Y - точка2.Y, 2));
        }
    }
}
