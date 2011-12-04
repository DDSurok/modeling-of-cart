using System;
using System.Drawing;

namespace Телега.Графические_объекты
{
    interface Графический_объект
    {
        Color Цвет;
        void Повернуть(double x, double y);
        void Нарисовать(Color цвет);
    }
}
