﻿namespace Телега.Интерфейс
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.TextColorLeft = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectLeftColor = new System.Windows.Forms.Button();
            this.panel1 = new Телега.Графические_объекты.Область_построения();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 552);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Стоп";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TextColorLeft
            // 
            this.TextColorLeft.Location = new System.Drawing.Point(93, 12);
            this.TextColorLeft.Name = "TextColorLeft";
            this.TextColorLeft.Size = new System.Drawing.Size(100, 20);
            this.TextColorLeft.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Цвет левого\r\nколеса";
            // 
            // btnSelectLeftColor
            // 
            this.btnSelectLeftColor.Location = new System.Drawing.Point(175, 12);
            this.btnSelectLeftColor.Name = "btnSelectLeftColor";
            this.btnSelectLeftColor.Size = new System.Drawing.Size(27, 20);
            this.btnSelectLeftColor.TabIndex = 4;
            this.btnSelectLeftColor.Text = "...";
            this.btnSelectLeftColor.UseVisualStyleBackColor = true;
            this.btnSelectLeftColor.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 508);
            this.panel1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 587);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSelectLeftColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextColorLeft);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox TextColorLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectLeftColor;
        private Графические_объекты.Область_построения panel1;
    }
}

