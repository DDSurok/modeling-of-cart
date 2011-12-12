using System;
using System.Drawing;

namespace Телега.Графические_объекты
{
    struct Телега
    {
        public Color Цвет { get; set; }
        private Точка Левая_ось, Правая_ось;
        public static void Установить_значение(ref Телега телега, Точка левая_ось, Точка правая_ось, Color цвет)
        {
            телега.Цвет = цвет;
            Телега.Обновить_положение(ref телега, левая_ось, правая_ось);
        }
        public static void Обновить_положение(ref Телега телега, Точка левая_ось, Точка правая_ось)
        {
            телега.Левая_ось = левая_ось;
            телега.Правая_ось = правая_ось;
        }
        public static void Нарисовать(Телега телега, Область_построения область_построения, ref Graphics gr)
        {
            Pen pen = new Pen(телега.Цвет);
            double x1v, y1v, x2v, y2v; // Координаты верхней части телеги
            double x1 = телега.Левая_ось.X,
                   y1 = телега.Левая_ось.Y,
                   x2 = телега.Правая_ось.X,
                   y2 = телега.Правая_ось.Y;
            Телега.Расчет_вершин(телега, область_построения, out x1v, out y1v, out x2v, out y2v);
            gr.DrawLine(pen, new Point((int)x1, (int)(область_построения.Height - y1)), new Point((int)x2, (int)(область_построения.Height - y2)));
            gr.DrawLine(pen, new Point((int)x1v, (int)(область_построения.Height - y1v)), new Point((int)x1, (int)(область_построения.Height - y1)));
            gr.DrawLine(pen, new Point((int)x2v, (int)(область_построения.Height - y2v)), new Point((int)x2, (int)(область_построения.Height - y2)));
            gr.DrawLine(pen, new Point((int)x1v, (int)(область_построения.Height - y1v)), new Point((int)x2v, (int)(область_построения.Height - y2v)));
        }

        private static void Расчет_вершин(Телега телега, Область_построения область_построения, out double x1v, out double y1v, out double x2v, out double y2v)
        {
            double x1 = телега.Левая_ось.X,
                   y1 = телега.Левая_ось.Y,
                   x2 = телега.Правая_ось.X,
                   y2 = телега.Правая_ось.Y;
            x1v = x1 - область_построения.Высота_телеги * (y2 - y1) / (x2 - x1);
            x2v = x2 - область_построения.Высота_телеги * (y2 - y1) / (x2 - x1);
            y1v = y1 + Math.Sqrt(Math.Pow(область_построения.Высота_телеги, 2) - Math.Pow((x1 - x1v), 2));
            y2v = y2 + Math.Sqrt(Math.Pow(область_построения.Высота_телеги, 2) - Math.Pow((x1 - x1v), 2));
        }
    }
}
