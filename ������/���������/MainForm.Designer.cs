namespace Телега.Интерфейс
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnSelectRightColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ColorRight = new System.Windows.Forms.TextBox();
            this.TrackSizeLeft = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextSizeLeft = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectLeftColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ColorLeft = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextSizeRight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.TrackSizeRight = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TextLenghtCart = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.TrackLenghtCart = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.ColorCart = new System.Windows.Forms.TextBox();
            this.btnSelectCartColor = new System.Windows.Forms.Button();
            this.TextSpeed = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.TrackSpeed = new System.Windows.Forms.TrackBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.panel1 = new Телега.Графические_объекты.Область_построения();
            ((System.ComponentModel.ISupportInitialize)(this.TrackSizeLeft)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextSizeLeft)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextSizeRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackSizeRight)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextLenghtCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackLenghtCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackSpeed)).BeginInit();
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
            this.button1.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(174, 553);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSelectRightColor
            // 
            this.btnSelectRightColor.Location = new System.Drawing.Point(169, 18);
            this.btnSelectRightColor.Name = "btnSelectRightColor";
            this.btnSelectRightColor.Size = new System.Drawing.Size(25, 20);
            this.btnSelectRightColor.TabIndex = 8;
            this.btnSelectRightColor.Text = "...";
            this.btnSelectRightColor.UseVisualStyleBackColor = true;
            this.btnSelectRightColor.Click += new System.EventHandler(this.btnSelectRightColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Цвет";
            // 
            // ColorRight
            // 
            this.ColorRight.Enabled = false;
            this.ColorRight.Location = new System.Drawing.Point(44, 19);
            this.ColorRight.Name = "ColorRight";
            this.ColorRight.Size = new System.Drawing.Size(119, 20);
            this.ColorRight.TabIndex = 6;
            // 
            // TrackSizeLeft
            // 
            this.TrackSizeLeft.LargeChange = 20;
            this.TrackSizeLeft.Location = new System.Drawing.Point(66, 49);
            this.TrackSizeLeft.Maximum = 200;
            this.TrackSizeLeft.Minimum = 20;
            this.TrackSizeLeft.Name = "TrackSizeLeft";
            this.TrackSizeLeft.Size = new System.Drawing.Size(128, 45);
            this.TrackSizeLeft.SmallChange = 5;
            this.TrackSizeLeft.TabIndex = 9;
            this.TrackSizeLeft.TickFrequency = 20;
            this.TrackSizeLeft.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TrackSizeLeft.Value = 20;
            this.TrackSizeLeft.ValueChanged += new System.EventHandler(this.TrackSizeLeft_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextSizeLeft);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSelectLeftColor);
            this.groupBox1.Controls.Add(this.TrackSizeLeft);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ColorLeft);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Левое колесо";
            // 
            // TextSizeLeft
            // 
            this.TextSizeLeft.Location = new System.Drawing.Point(6, 67);
            this.TextSizeLeft.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.TextSizeLeft.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TextSizeLeft.Name = "TextSizeLeft";
            this.TextSizeLeft.Size = new System.Drawing.Size(54, 20);
            this.TextSizeLeft.TabIndex = 14;
            this.TextSizeLeft.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TextSizeLeft.ValueChanged += new System.EventHandler(this.TextSizeLeft_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Размер";
            // 
            // btnSelectLeftColor
            // 
            this.btnSelectLeftColor.Location = new System.Drawing.Point(169, 19);
            this.btnSelectLeftColor.Name = "btnSelectLeftColor";
            this.btnSelectLeftColor.Size = new System.Drawing.Size(25, 20);
            this.btnSelectLeftColor.TabIndex = 7;
            this.btnSelectLeftColor.Text = "...";
            this.btnSelectLeftColor.UseVisualStyleBackColor = true;
            this.btnSelectLeftColor.Click += new System.EventHandler(this.SelectLeftColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Цвет";
            // 
            // ColorLeft
            // 
            this.ColorLeft.Enabled = false;
            this.ColorLeft.Location = new System.Drawing.Point(44, 19);
            this.ColorLeft.Name = "ColorLeft";
            this.ColorLeft.Size = new System.Drawing.Size(119, 20);
            this.ColorLeft.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextSizeRight);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TrackSizeRight);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ColorRight);
            this.groupBox2.Controls.Add(this.btnSelectRightColor);
            this.groupBox2.Location = new System.Drawing.Point(219, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Правое колесо";
            // 
            // TextSizeRight
            // 
            this.TextSizeRight.Location = new System.Drawing.Point(9, 67);
            this.TextSizeRight.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.TextSizeRight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TextSizeRight.Name = "TextSizeRight";
            this.TextSizeRight.Size = new System.Drawing.Size(49, 20);
            this.TextSizeRight.TabIndex = 14;
            this.TextSizeRight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TextSizeRight.ValueChanged += new System.EventHandler(this.TextSizeRight_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Размер";
            // 
            // TrackSizeRight
            // 
            this.TrackSizeRight.LargeChange = 20;
            this.TrackSizeRight.Location = new System.Drawing.Point(64, 49);
            this.TrackSizeRight.Maximum = 200;
            this.TrackSizeRight.Minimum = 20;
            this.TrackSizeRight.Name = "TrackSizeRight";
            this.TrackSizeRight.Size = new System.Drawing.Size(130, 45);
            this.TrackSizeRight.SmallChange = 10;
            this.TrackSizeRight.TabIndex = 12;
            this.TrackSizeRight.TickFrequency = 20;
            this.TrackSizeRight.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TrackSizeRight.Value = 20;
            this.TrackSizeRight.ValueChanged += new System.EventHandler(this.TrackSizeRight_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TextLenghtCart);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TrackLenghtCart);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.ColorCart);
            this.groupBox3.Controls.Add(this.btnSelectCartColor);
            this.groupBox3.Location = new System.Drawing.Point(425, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Телега";
            // 
            // TextLenghtCart
            // 
            this.TextLenghtCart.Location = new System.Drawing.Point(6, 67);
            this.TextLenghtCart.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.TextLenghtCart.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.TextLenghtCart.Name = "TextLenghtCart";
            this.TextLenghtCart.Size = new System.Drawing.Size(49, 20);
            this.TextLenghtCart.TabIndex = 13;
            this.TextLenghtCart.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.TextLenghtCart.ValueChanged += new System.EventHandler(this.TextLenghtCart_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Длина";
            // 
            // TrackLenghtCart
            // 
            this.TrackLenghtCart.LargeChange = 20;
            this.TrackLenghtCart.Location = new System.Drawing.Point(64, 49);
            this.TrackLenghtCart.Maximum = 300;
            this.TrackLenghtCart.Minimum = 100;
            this.TrackLenghtCart.Name = "TrackLenghtCart";
            this.TrackLenghtCart.Size = new System.Drawing.Size(130, 45);
            this.TrackLenghtCart.SmallChange = 10;
            this.TrackLenghtCart.TabIndex = 18;
            this.TrackLenghtCart.TickFrequency = 20;
            this.TrackLenghtCart.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TrackLenghtCart.Value = 100;
            this.TrackLenghtCart.ValueChanged += new System.EventHandler(this.TrackLenghtCart_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Цвет";
            // 
            // ColorCart
            // 
            this.ColorCart.Enabled = false;
            this.ColorCart.Location = new System.Drawing.Point(44, 19);
            this.ColorCart.Name = "ColorCart";
            this.ColorCart.Size = new System.Drawing.Size(119, 20);
            this.ColorCart.TabIndex = 15;
            // 
            // btnSelectCartColor
            // 
            this.btnSelectCartColor.Location = new System.Drawing.Point(169, 18);
            this.btnSelectCartColor.Name = "btnSelectCartColor";
            this.btnSelectCartColor.Size = new System.Drawing.Size(25, 20);
            this.btnSelectCartColor.TabIndex = 17;
            this.btnSelectCartColor.Text = "...";
            this.btnSelectCartColor.UseVisualStyleBackColor = true;
            // 
            // TextSpeed
            // 
            this.TextSpeed.Location = new System.Drawing.Point(631, 34);
            this.TextSpeed.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.TextSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TextSpeed.Name = "TextSpeed";
            this.TextSpeed.Size = new System.Drawing.Size(51, 20);
            this.TextSpeed.TabIndex = 13;
            this.TextSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TextSpeed.ValueChanged += new System.EventHandler(this.TextSpeed_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(631, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Скорость";
            // 
            // TrackSpeed
            // 
            this.TrackSpeed.Location = new System.Drawing.Point(693, 15);
            this.TrackSpeed.Maximum = 15;
            this.TrackSpeed.Minimum = 1;
            this.TrackSpeed.Name = "TrackSpeed";
            this.TrackSpeed.Size = new System.Drawing.Size(126, 45);
            this.TrackSpeed.TabIndex = 15;
            this.TrackSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TrackSpeed.Value = 1;
            this.TrackSpeed.ValueChanged += new System.EventHandler(this.TrackSpeed_ValueChanged);
            // 
            // timer
            // 
            this.timer.Interval = 250;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(93, 553);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 16;
            this.btnPause.Text = "Пауза";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 428);
            this.panel1.TabIndex = 5;
            this.panel1.Высота_телеги = 50;
            this.panel1.Длина_телеги = 100;
            this.panel1.Размер_левого_колеса = 25;
            this.panel1.Размер_правого_колеса = 50;
            this.panel1.Скорость_движения = 1;
            this.panel1.Цвет_левого_колеса = System.Drawing.Color.Red;
            this.panel1.Цвет_правого_колеса = System.Drawing.Color.Red;
            this.panel1.Цвет_телеги = System.Drawing.Color.Green;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 587);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.TrackSpeed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextSpeed);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "Моделирование движения телеги с квадратными колесами";
            ((System.ComponentModel.ISupportInitialize)(this.TrackSizeLeft)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextSizeLeft)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextSizeRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackSizeRight)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextLenghtCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackLenghtCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private Графические_объекты.Область_построения panel1;
        private System.Windows.Forms.Button btnSelectRightColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ColorRight;
        private System.Windows.Forms.TrackBar TrackSizeLeft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectLeftColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ColorLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar TrackSizeRight;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar TrackLenghtCart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ColorCart;
        private System.Windows.Forms.Button btnSelectCartColor;
        private System.Windows.Forms.NumericUpDown TextLenghtCart;
        private System.Windows.Forms.NumericUpDown TextSizeLeft;
        private System.Windows.Forms.NumericUpDown TextSizeRight;
        private System.Windows.Forms.NumericUpDown TextSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar TrackSpeed;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnPause;
    }
}

