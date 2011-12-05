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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.colorDialog1.Color = Color.Green;
            this.colorDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.Сдвинуть();
        }

        

    }
}
