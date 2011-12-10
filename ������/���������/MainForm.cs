using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Телега.Интерфейс
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Инициализация параметров в окне
            // Параметры левого колеса
            this.ColorLeft.BackColor = this.panel1.Цвет_левого_колеса;
            this.TrackSizeLeft.Value = this.panel1.Размер_левого_колеса;
            // Параметры правого колеса
            this.ColorRight.BackColor = this.panel1.Цвет_правого_колеса;
            this.TrackSizeRight.Value = this.panel1.Размер_правого_колеса;
            // Параметры телеги
            this.ColorCart.BackColor = this.panel1.Цвет_телеги;
            this.TrackLenghtCart.Value = this.panel1.Длина_телеги;
            // Скорость движения
            this.TrackSpeed.Value = this.panel1.Скорость_движения;
        }

        private void SelectLeftColor_Click(object sender, EventArgs e)
        {
            this.colorDialog1.Color = this.panel1.Цвет_левого_колеса;
            this.colorDialog1.ShowDialog();
            this.ColorLeft.BackColor = this.colorDialog1.Color;
            this.panel1.Цвет_левого_колеса = this.colorDialog1.Color;
        }

        private void btnSelectRightColor_Click(object sender, EventArgs e)
        {
            this.colorDialog1.Color = this.panel1.Цвет_правого_колеса;
            this.colorDialog1.ShowDialog();
            this.ColorRight.BackColor = this.colorDialog1.Color;
            this.panel1.Цвет_правого_колеса = this.colorDialog1.Color;
        }

        private void btnSelectCartColor_Click(object sender, EventArgs e)
        {
            this.colorDialog1.Color = this.panel1.Цвет_телеги;
            this.colorDialog1.ShowDialog();
            this.ColorCart.BackColor = this.colorDialog1.Color;
            this.panel1.Цвет_телеги = this.colorDialog1.Color;
        }

        private void TrackSizeLeft_ValueChanged(object sender, EventArgs e)
        {
            this.TextSizeLeft.Value = this.TrackSizeLeft.Value;
            this.panel1.Размер_левого_колеса = this.TrackSizeLeft.Value;
        }

        private void TrackSizeRight_ValueChanged(object sender, EventArgs e)
        {
            this.TextSizeRight.Value = this.TrackSizeRight.Value;
            this.panel1.Размер_правого_колеса = this.TrackSizeRight.Value;
        }

        private void TextSizeLeft_ValueChanged(object sender, EventArgs e)
        {
            this.TrackSizeLeft.Value = (int)this.TextSizeLeft.Value;
            this.panel1.Размер_левого_колеса = this.TrackSizeLeft.Value;
        }

        private void TextSizeRight_ValueChanged(object sender, EventArgs e)
        {
            this.TrackSizeRight.Value = (int)this.TextSizeRight.Value;
            this.panel1.Размер_правого_колеса = this.TrackSizeRight.Value;
        }

        private void TextLenghtCart_ValueChanged(object sender, EventArgs e)
        {
            this.TrackLenghtCart.Value = (int)this.TextLenghtCart.Value;
            this.panel1.Длина_телеги = this.TrackLenghtCart.Value;
        }

        private void TrackLenghtCart_ValueChanged(object sender, EventArgs e)
        {
            this.TextLenghtCart.Value = this.TrackLenghtCart.Value;
            this.panel1.Длина_телеги = this.TrackLenghtCart.Value;
        }

        private void TextSpeed_ValueChanged(object sender, EventArgs e)
        {
            this.TrackSpeed.Value = (int)this.TextSpeed.Value;
            this.panel1.Скорость_движения = this.TrackSpeed.Value;
        }

        private void TrackSpeed_ValueChanged(object sender, EventArgs e)
        {
            this.TextSpeed.Value = this.TrackSpeed.Value;
            this.panel1.Скорость_движения = this.TrackSpeed.Value;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                this.panel1.Сдвинуть();
                this.timer.Enabled = true;
            }
            catch (Exception ex)
            {
                this.btnStop_Click(sender, e);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Заводим таймер
            this.timer.Enabled = true;
            // Меняем доступность кнопок
            this.btnStart.Enabled = false;
            this.btnStop.Enabled = true;
            this.btnPause.Enabled = true;
            // Блокируем изменение параметров
            this.btnSelectLeftColor.Enabled = false;
            this.btnSelectRightColor.Enabled = false;
            this.btnSelectCartColor.Enabled = false;
            this.TrackSizeLeft.Enabled = false;
            this.TrackSizeRight.Enabled = false;
            this.TrackLenghtCart.Enabled = false;
            this.TrackSpeed.Enabled = false;
            this.TextSizeLeft.Enabled = false;
            this.TextSizeRight.Enabled = false;
            this.TextLenghtCart.Enabled = false;
            this.TextSpeed.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Выключаем таймер
            this.timer.Enabled = false;
            // Меняем доступность кнопок
            this.btnStart.Enabled = true;
            this.btnPause.Enabled = false;
            this.btnStop.Enabled = false;
            // Разрешаем изменение всех параметров
            this.btnSelectLeftColor.Enabled = true;
            this.btnSelectRightColor.Enabled = true;
            this.btnSelectCartColor.Enabled = true;
            this.TrackSizeLeft.Enabled = true;
            this.TrackSizeRight.Enabled = true;
            this.TrackLenghtCart.Enabled = true;
            this.TrackSpeed.Enabled = true;
            this.TextSizeLeft.Enabled = true;
            this.TextSizeRight.Enabled = true;
            this.TextLenghtCart.Enabled = true;
            this.TextSpeed.Enabled = true;
            this.panel1.Сбросить_движение();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            // Выключаем таймер
            this.timer.Enabled = false;
            // Меняем доступность кнопок
            this.btnStart.Enabled = true;
            this.btnPause.Enabled = false;
            this.btnStop.Enabled = true;
            // Разрешаем изменять скорость движения
            this.TrackSpeed.Enabled = true;
            this.TextSpeed.Enabled = true;
        }
    }
}
