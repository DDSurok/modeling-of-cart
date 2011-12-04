using System;
using System.Drawing;

namespace Телега.Графические_объекты
{
    class Поверхность : Графический_объект
    {
        double Смещение_Y;
        Color Цвет;
        double Угол_поворота_колеса;
        double X_оси_поворота, Y_оси_поворота;
        public Поверхность(double Размер_квадрата, Color цвет_квадрата, Color цвет_поверхности, double смещение_Y)
        {
        }
        public bool Перемещение_оси_поворота();
        public void Начать_движение();
        public void Нарисовать_поверхность();
        public void Графический_объект.Повернуть(double x, double y)
        {
        }
        public void Графический_объект.Нарисовать(Color цвет)
        {
        }
    }
}
