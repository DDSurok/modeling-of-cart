using System;
using System.Drawing;
using System.Windows.Forms;

namespace Телега.Графические_объекты
{
    class Область_построения : Panel
    {
        public Поверхность поверхность;
        public Параметры параметры;
        Колесо Правое, Левое;
        Телега телега;
        public Область_построения()
            : base()
        {
            this.параметры = new Параметры();
            this.параметры.Высота_канвы = this.Height;
            this.поверхность = new Поверхность(this, Color.Green);
            this.Правое = new Колесо(this, 
                                     this.параметры.Размер_правого_колеса,
                                     this.параметры.Цвет_правого_колеса,
                                     0 - this.параметры.Размер_правого_колеса / 2,
                                     this.параметры.Смещение_по_Y + this.параметры.Размер_правого_колеса / 2);
            this.Левое = new Колесо(this,
                                    this.параметры.Размер_левого_колеса,
                                    this.параметры.Цвет_левого_колеса,
                                    0 - this.параметры.Размер_правого_колеса / 2 - Math.Sqrt(Math.Pow(this.параметры.Длина_телеги, 2) - Math.Pow(this.параметры.Размер_левого_колеса - this.параметры.Размер_правого_колеса, 2)),
                                    this.параметры.Смещение_по_Y + this.параметры.Размер_левого_колеса / 2);
            this.телега = new Телега(this,
                                     this.Левое.Центр,
                                     this.Правое.Центр,
                                     this.параметры.Цвет_телеги);
        }

        public void Сдвинуть()
        {
            this.Правое.Повернуть();
            while (Точка.Расстояние_между_двумя_точками(this.Правое.Центр, this.Левое.Центр) > this.параметры.Длина_телеги)
                this.Левое.Повернуть();
            this.телега.Обновить_положение(this.Левое.Центр, this.Правое.Центр);
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
                this.параметры.Высота_канвы = value;
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
                this.параметры.Высота_канвы = Size.Height;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics gr = this.CreateGraphics();
            gr.Clear(Color.Black);
            this.поверхность.Нарисовать(ref gr);
            this.Правое.Нарисовать(ref gr);
            this.Левое.Нарисовать(ref gr);
            this.телега.Нарисовать(ref gr);
        }
    }
}
