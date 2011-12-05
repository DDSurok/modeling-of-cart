using System;
using System.Drawing;
using System.Windows.Forms;

namespace Телега.Графические_объекты
{
    class Область_построения : Panel
    {
        public Color Цвет_левого_колеса = Color.Red;
        public int Размер_левого_колеса;
        public Color Цвет_правого_колеса = Color.Red;
        public int Размер_правого_колеса = 50;
        public Color Цвет_телеги;
        Поверхность поверхность;
        Колесо Правое, Левое;
        public Область_построения()
            : base()
        {
            Параметры.Высота_канвы = this.Height;
            поверхность = new Поверхность(Color.Green);
            this.Правое = new Колесо(this.Размер_правого_колеса, this.Цвет_правого_колеса, 0 - this.Размер_правого_колеса / 2, Параметры.Смещение_по_Y + this.Размер_правого_колеса / 2);
        }
        public void Сдвинуть()
        {
            this.Правое.Повернуть();
            this.OnPaint(null);
        }
        public new int Height
        {
            get
            {
                return base.Height;
            }
            set
            {
                Параметры.Высота_канвы = value;
                base.Height = value;
            }
        }
        public new Size Size
        {
            get
            {
                return base.Size;
            }
            set
            {
                base.Size = value;
                Параметры.Высота_канвы = Size.Height;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics gr = this.CreateGraphics();
            gr.Clear(Color.Black);
            this.поверхность.Нарисовать(ref gr);
            this.Правое.Нарисовать(ref gr);
        }
    }
}
