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
            this.TextColorLeft.Text = this.panel1.параметры.Цвет_левого_колеса.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.colorDialog1.Color = this.panel1.параметры.Цвет_левого_колеса;
            this.colorDialog1.ShowDialog();
            this.TextColorLeft.Text = this.colorDialog1.Color.ToString();
            this.panel1.параметры.Цвет_левого_колеса = this.colorDialog1.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                this.panel1.Сдвинуть();
            }
        }

        

    }
}
