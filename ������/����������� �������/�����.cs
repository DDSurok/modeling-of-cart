using System;
using System.Drawing;

namespace Телега.Графические_объекты
{
    class Линия : Графический_объект
    {
        public Точка Начало, Конец;
        private Область_построения Родитель;
        public Color Цвет { get; set; }
        /// <summary>
        /// Создает экземпляр линии
        /// </summary>
        /// <param name="родитель">Панель для доступа к ее высоте панели, поверхности и параметрам поворота</param>
        /// <param name="x и y">Координаты начала и конца линии</param>
        /// <param name="цвет">Цвет линии</param>
        public Линия(Область_построения родитель, double x1, double y1, double x2, double y2, Color цвет)
        {
            this.Начало = new Точка(родитель, x1, y1, цвет);
            this.Конец = new Точка(родитель, x2, y2, цвет);
            this.Цвет = цвет;
            this.Родитель = родитель;
        }
        /// <summary>
        /// Отрисовывает линию на поверхности рисования gr
        /// </summary>
        /// <param name="gr">Поверхность рисования</param>
        public void Нарисовать(ref Graphics gr)
        {
            Pen pen = new Pen(this.Цвет);
            gr.DrawLine(pen,
                        (float)(this.Начало.X),
                        (float)(this.Родитель.Height - this.Начало.Y),
                        (float)(this.Конец.X),
                        (float)(this.Родитель.Height - this.Конец.Y));
        }
        /// <summary>
        /// Поворачивает линию вокруг указанной оси
        /// </summary>
        /// <param name="x и y">Координаты оси поворота</param>
        public void Повернуть(double x, double y)
        {
            this.Начало.Повернуть(x, y);
            this.Конец.Повернуть(x, y);
        }
    }
}
