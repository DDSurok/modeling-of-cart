using System;
using System.Drawing;

namespace Телега.Графические_объекты
{
    class Поверхность : Графический_объект
    {
        private int Коэф1, Коэф2;
        public Color Цвет { get; set; }
        private Область_построения Родитель;
        /// <summary>
        /// Создает экземпляр поверхности
        /// </summary>
        /// <param name="родитель">Панель для доступа к ее высоте панели</param>
        /// <param name="цвет">Цвет поверхности</param>
        public Поверхность(Область_построения родитель, Color цвет)
        {
            this.Цвет = цвет;
            this.Родитель = родитель;
            Random rand = new Random();
            Коэф1 = rand.Next(20, 150);
            Коэф2 = rand.Next(20, 150);
        }
        /// <summary>
        /// Реализует расчет значения функции для аргумента X
        /// </summary>
        public double Значение_для_X(double x)
        {
            if (x <= 0)
                return this.Родитель.Смещение_по_Y;
            else
                return Math.Sin(x / this.Коэф1) * 1.5 * this.Родитель.Смещение_по_Y / 4
                    + Math.Sin(x / this.Коэф2) * 1.5 * this.Родитель.Смещение_по_Y / 4
                    + this.Родитель.Смещение_по_Y;
        }
        /// <summary>
        /// Заглушка. Не используется. Реализована для заполнения методов интерфейса
        /// </summary>
        public void Повернуть(double x, double y)
        {
            throw new Exception("Не используется");
        }
        /// <summary>
        /// Отрисовывает функцию на поверхности рисования gr
        /// </summary>
        /// <param name="gr">Поверхность рисования</param>
        public void Нарисовать(ref Graphics gr)
        {
            Point[] line = new Point[2000];
            for (int x = 0; x<2000; x++)
                line[x] = Point.Ceiling(new PointF((float)x, (float)(this.Родитель.Height - this.Значение_для_X(x))));
            gr.DrawLines(new Pen(this.Цвет), line);
        }
    }
}
