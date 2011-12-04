using System;
using System.Drawing;

namespace Телега.Графические_объекты
{
    class Квадратное_колесо : Графический_объект
    {
        Color Цвет;
        double Размер;
        Линия[] Стороны;
        public Квадратное_колесо(double размер, Color цвет)
        {
            this.Размер = размер;
            this.Цвет = цвет;
        }
        public void Повернуть(double x, double y)
        {
            
        }
        public void Нарисовать(Color цвет)
        {
            
        }
    }
}
