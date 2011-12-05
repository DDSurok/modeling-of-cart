using System;
using System.Drawing;

namespace Телега.Графические_объекты
{
    interface Графический_объект
    {
        void Повернуть(double x, double y);
        void Нарисовать(ref Graphics gr);
    }
}
