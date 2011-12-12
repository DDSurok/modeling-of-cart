using System;
using System.Drawing;

namespace Телега.Графические_объекты
{
    class Точка : Графический_объект
    {
        public Color Цвет { get; set; }
        public double X, Y;
        private Область_построения Родитель;
        /// <summary>
        /// Создает экземпляр точки
        /// </summary>
        /// <param name="родитель">Панель для доступа к ее высоте панели, поверхности и параметрам поворота</param>
        /// <param name="x и y">Координаты создоваемой точки</param>
        /// <param name="цвет">Цвет точки</param>
        public Точка (Область_построения родитель, double x, double y, Color цвет)
        {
            this.X = x;
            this.Y = y;
            this.Цвет = цвет;
            this.Родитель = родитель;
        }
        /// <summary>
        /// Выполняет поворот точки вокруг заданной оси
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public virtual void Повернуть(double x, double y)
        {
            double tempx = (this.X - x) * Math.Cos(this.Родитель.Приращение_угла) - (this.Y - y) * Math.Sin(this.Родитель.Приращение_угла) + x;
            double tempy = (this.X - x) * Math.Sin(this.Родитель.Приращение_угла) + (this.Y - y) * Math.Cos(this.Родитель.Приращение_угла) + y;
            this.X = tempx;
            this.Y = tempy;
        }
        /// <summary>
        /// Рисовать точку не имеет смысла
        /// </summary>
        /// <param name="gr"></param>
        public virtual void Нарисовать(ref Graphics gr)
        {
        }
        /// <summary>
        /// Определяет расстояние между двумя точками
        /// </summary>
        public static double Расстояние_между_двумя_точками(Точка точка1, Точка точка2)
        {
            return Math.Sqrt(Math.Pow(точка1.X - точка2.X, 2) + Math.Pow(точка1.Y - точка2.Y, 2));
        }
    }
}
