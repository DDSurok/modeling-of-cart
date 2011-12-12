using System;
using System.Drawing;

namespace Телега.Графические_объекты
{
    class Телега : Графический_объект
    {
        public Color Цвет { get; set; }
        private Точка Левая_ось, Правая_ось;
        public Область_построения Родитель;
        /// <summary>
        /// Создает экземпляр телеги
        /// </summary>
        /// <param name="родитель">Панель для доступа к ее высоте панели, поверхности и параметрам поворота</param>
        /// <param name="левая_ось">левая нижняя точка</param>
        /// <param name="правая_ось">правая нижняя точка</param>
        /// <param name="цвет">Цвет телеги</param>
        public Телега(Область_построения родитель, Точка левая_ось, Точка правая_ось, Color цвет)
        {
            this.Цвет = цвет;
            this.Родитель = родитель;
            this.Обновить_положение(левая_ось, правая_ось);
        }
        /// <summary>
        /// Обновить значения нижних точек
        /// </summary>
        public void Обновить_положение(Точка левая_ось, Точка правая_ось)
        {
            this.Левая_ось = левая_ось;
            this.Правая_ось = правая_ось;
        }
        public void Повернуть(double x, double y)
        {
            throw new Exception("Не используется");
        }
        /// <summary>
        /// Отрисовывает телегу на поверхности рисования gr
        /// </summary>
        /// <param name="gr">Поверхность рисования</param>
        public void Нарисовать(ref Graphics gr)
        {
            Pen pen = new Pen(this.Цвет);
            double x1v, y1v, x2v, y2v; // Координаты верхней части телеги
            double x1 = this.Левая_ось.X,
                   y1 = this.Левая_ось.Y,
                   x2 = this.Правая_ось.X,
                   y2 = this.Правая_ось.Y;
            this.Расчет_вершин(out x1v, out y1v, out x2v, out y2v);
            gr.DrawLine(pen, new Point((int)x1, (int)(this.Родитель.Height - y1)), new Point((int)x2, (int)(this.Родитель.Height - y2)));
            gr.DrawLine(pen, new Point((int)x1v, (int)(this.Родитель.Height - y1v)), new Point((int)x1, (int)(this.Родитель.Height - y1)));
            gr.DrawLine(pen, new Point((int)x2v, (int)(this.Родитель.Height - y2v)), new Point((int)x2, (int)(this.Родитель.Height - y2)));
            gr.DrawLine(pen, new Point((int)x1v, (int)(this.Родитель.Height - y1v)), new Point((int)x2v, (int)(this.Родитель.Height - y2v)));
        }
        /// <summary>
        /// Расчет координат верхних точек телеги
        /// </summary>
        private void Расчет_вершин(out double x1v, out double y1v, out double x2v, out double y2v)
        {
            double x1 = this.Левая_ось.X,
                   y1 = this.Левая_ось.Y,
                   x2 = this.Правая_ось.X,
                   y2 = this.Правая_ось.Y;
            x1v = x1 - this.Родитель.Высота_телеги * (y2 - y1) / (x2 - x1);
            x2v = x2 - this.Родитель.Высота_телеги * (y2 - y1) / (x2 - x1);
            y1v = y1 + Math.Sqrt(Math.Pow(this.Родитель.Высота_телеги, 2) - Math.Pow((x1 - x1v), 2));
            y2v = y2 + Math.Sqrt(Math.Pow(this.Родитель.Высота_телеги, 2) - Math.Pow((x1 - x1v), 2));
        }
    }
}
