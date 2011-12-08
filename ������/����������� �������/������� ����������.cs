﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Телега.Графические_объекты
{
    class Область_построения : Panel
    {
        private Параметры параметры;
        public Color Цвет_левого_колеса
        {
            get
            {
                return this.параметры.Цвет_левого_колеса;
            }
            set
            {
                this.параметры.Цвет_левого_колеса = value;
                this.Инициализация_графических_объектов();
            }
        }
        public int Размер_левого_колеса
        {
            get
            {
                return this.параметры.Размер_левого_колеса;
            }
            set
            {
                this.параметры.Размер_левого_колеса = value;
                this.Инициализация_графических_объектов();
            }
        }
        public Color Цвет_правого_колеса
        {
            get
            {
                return this.параметры.Цвет_правого_колеса;
            }
            set
            {
                this.параметры.Цвет_правого_колеса = value;
                this.Инициализация_графических_объектов();
            }
        }
        public int Размер_правого_колеса
        {
            get
            {
                return this.параметры.Размер_правого_колеса;
            }
            set
            {
                this.параметры.Размер_правого_колеса = value;
                this.Инициализация_графических_объектов();
            }
        }
        public Color Цвет_телеги
        {
            get
            {
                return this.параметры.Цвет_телеги;
            }
            set
            {
                this.параметры.Цвет_телеги = value;
                this.Инициализация_графических_объектов();
            }
        }
        public int Длина_телеги
        {
            get
            {
                return this.параметры.Длина_телеги;
            }
            set
            {
                this.параметры.Длина_телеги = value;
                this.Инициализация_графических_объектов();
            }
        }
        public int Высота_телеги
        {
            get
            {
                return this.параметры.Высота_телеги;
            }
            set
            {
                this.параметры.Высота_телеги = value;
                this.Инициализация_графических_объектов();
            }
        }
        public int Скорость_движения
        {
            get
            {
                return (int)Math.Round(this.параметры.Скорость_движения * 60);
            }
            set
            {
                this.параметры.Скорость_движения = (double)value / 60;
            }
        }
        public double Приращение_угла
        {
            get
            {
                return 0 - Math.PI * this.Скорость_движения / 180 / 60;
            }
        }
        public int Смещение_по_Y
        {
            get
            {
                return this.параметры.Смещение_по_Y;
            }
        }
        public Поверхность поверхность;
        Колесо Правое, Левое;
        Телега телега;
        public Область_построения()
            : base()
        {
            this.параметры = new Параметры();
            this.Инициализация_графических_объектов();
        }

        private void Инициализация_графических_объектов()
        {
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

        public void Сбросить_движение()
        {
            this.Инициализация_графических_объектов();
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
