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
        public virtual override void Нарисовать(Color цвет)
        {
            
        }
        public virtual override void Повернуть(double x, double y)
        {
            
        }
    }
}
