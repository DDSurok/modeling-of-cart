using System;
using System.Drawing;

namespace Телега.Графические_объекты
{
    class Колесо : Квадрат, Графический_объект
    {
        public Колесо(double Размер_колеса, Color цвет, double центр_X, double центр_Y, double угол_поворота = 0) : base(центр_X, центр_Y, Размер_колеса, цвет)
        {
            this.Цвет = цвет;
            this.Ось_поворота = base.Вершины[1];
        }
        Точка Ось_поворота;
        public void Передвинуть_ось_вращения()
        {
            if (this.Ось_поворота == base.Вершины[3])
                this.Ось_поворота = base.Вершины[0];
            else if(this.Ось_поворота == base.Вершины[0])
                this.Ось_поворота = base.Вершины[1];
            else if(this.Ось_поворота == base.Вершины[1])
                this.Ось_поворота = base.Вершины[2];
            else if(this.Ось_поворота == base.Вершины[2])
                this.Ось_поворота = base.Вершины[3];
        }
        public Точка Центр
        {
            get
            {
                return this;
            }
        }
        public void Повернуть()
        {
            base.Повернуть(this.Ось_поворота.X, this.Ось_поворота.Y);
        }
    }
}
