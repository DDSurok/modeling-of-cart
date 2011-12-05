using System;
using System.Drawing;

namespace Телега.Графические_объекты
{
    class Линия : Графический_объект
    {
        public Линия(double x1, double y1, double x2, double y2, Color цвет)
        {
            this.Начало = new Точка(x1, y1, цвет);
            this.Конец = new Точка(x2, y2, цвет);
            this.Цвет = цвет;
        }
        Точка Начало, Конец;
        Color Цвет;
        public void Нарисовать(ref Graphics gr)
        {
            Pen pen = new Pen(this.Цвет);
            gr.DrawLine(pen,
                (float)(this.Начало.X),
                (float)(Параметры.Высота_канвы - this.Начало.Y),
                (float)(this.Конец.X),
                (float)(Параметры.Высота_канвы - this.Конец.Y));
        }
        public void Повернуть(double x, double y)
        {
            this.Начало.Повернуть(x, y);
            this.Конец.Повернуть(x, y);
        }
    }
}
