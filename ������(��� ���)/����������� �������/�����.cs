using System;
using System.Drawing;

namespace Телега.Графические_объекты
{
    struct Линия
    {
        public Точка Начало, Конец;
        public Color Цвет;
        public static void Установить_значения(ref Линия линия, double x1, double y1, double x2, double y2, Color цвет)
        {
            Точка.Установить_значения(ref линия.Начало, x1, y1, цвет);
            Точка.Установить_значения(ref линия.Конец, x2, y2, цвет);
            линия.Цвет = цвет;
        }
        public static void Нарисовать(Линия линия, Область_построения область_построения, ref Graphics gr)
        {
            Pen pen = new Pen(линия.Цвет);
            gr.DrawLine(pen,
                        (float)(линия.Начало.X),
                        (float)(область_построения.Height - линия.Начало.Y),
                        (float)(линия.Конец.X),
                        (float)(область_построения.Height - линия.Конец.Y));
        }
        public static void Повернуть(ref Линия линия, Область_построения область_построения, double x, double y)
        {
            Точка.Повернуть(ref линия.Начало, область_построения, x, y);
            Точка.Повернуть(ref линия.Конец, область_построения, x, y);
        }
    }
}
