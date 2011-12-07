using System;
using System.Drawing;

namespace Телега.Графические_объекты
{
    class Поверхность : Графический_объект
    {
        public Поверхность(Область_построения родитель, Color цвет)
        {
            this.Цвет = цвет;
            this.Родитель = родитель;
        }
        public Color Цвет { get; set; }
        private Область_построения Родитель;
        public double Значение_для_X(double x)
        {
            if (x <= 0)
                return this.Родитель.параметры.Смещение_по_Y;
            else
                return Math.Sin(x / 100) * 3 * this.Родитель.параметры.Смещение_по_Y / 4 + this.Родитель.параметры.Смещение_по_Y;
        }
        public void Повернуть(double x, double y)
        {
            throw new Exception("Не используется");
        }

        public void Нарисовать(ref Graphics gr)
        {
            Point[] line = new Point[2000];
            for (int x = 0; x<2000; x++)
                line[x] = Point.Ceiling(new PointF((float)x, (float)(this.Родитель.параметры.Высота_канвы - this.Значение_для_X(x))));
            gr.DrawLines(new Pen(this.Цвет), line);
        }
    }
}
