using System;
using System.Drawing;

namespace Телега.Графические_объекты
{
    struct Поверхность
    {
        public static void Установить_значения(ref Поверхность поверхность, Color цвет)
        {
            поверхность.Цвет = цвет;
            Random rand = new Random();
            поверхность.Коэф1 = rand.Next(20, 150);
            поверхность.Коэф2 = rand.Next(20, 150);
        }
        private int Коэф1, Коэф2;
        public Color Цвет { get; set; }
        public static double Значение_для_X(Поверхность поверхность, Область_построения область_построения, double x)
        {
            if (x <= 0)
                return область_построения.Смещение_по_Y;
            else
                return Math.Sin(x / поверхность.Коэф1) * 1.5 * область_построения.Смещение_по_Y / 4
                    + Math.Sin(x / поверхность.Коэф2) * 1.5 * область_построения.Смещение_по_Y / 4
                    + область_построения.Смещение_по_Y;
        }
        public static void Нарисовать(Поверхность поверхность, Область_построения область_построения, ref Graphics gr)
        {
            Point[] line = new Point[область_построения.Width+1];
            for (int x = 0; x<область_построения.Width+1; x++)
                line[x] = Point.Ceiling(new PointF((float)x, (float)(область_построения.Height - Поверхность.Значение_для_X(поверхность, область_построения, x))));
            gr.DrawLines(new Pen(поверхность.Цвет), line);
        }
    }
}
