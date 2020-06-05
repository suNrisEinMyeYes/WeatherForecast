namespace WeatherForecast
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DayNumbLbl = new System.Windows.Forms.Label();
            this.DayPeriodLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SunnyLbl = new System.Windows.Forms.Label();
            this.CloudyLbl = new System.Windows.Forms.Label();
            this.RainyLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "StartSimulations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Day: ";
            // 
            // DayNumbLbl
            // 
            this.DayNumbLbl.AutoSize = true;
            this.DayNumbLbl.Location = new System.Drawing.Point(233, 66);
            this.DayNumbLbl.Name = "DayNumbLbl";
            this.DayNumbLbl.Size = new System.Drawing.Size(13, 13);
            this.DayNumbLbl.TabIndex = 2;
            this.DayNumbLbl.Text = "0";
            // 
            // DayPeriodLbl
            // 
            this.DayPeriodLbl.AutoSize = true;
            this.DayPeriodLbl.Location = new System.Drawing.Point(288, 66);
            this.DayPeriodLbl.Name = "DayPeriodLbl";
            this.DayPeriodLbl.Size = new System.Drawing.Size(0, 13);
            this.DayPeriodLbl.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(43, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 87);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Statistics";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sunny";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cloudy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rainy";
            // 
            // SunnyLbl
            // 
            this.SunnyLbl.AutoSize = true;
            this.SunnyLbl.Location = new System.Drawing.Point(334, 180);
            this.SunnyLbl.Name = "SunnyLbl";
            this.SunnyLbl.Size = new System.Drawing.Size(35, 13);
            this.SunnyLbl.TabIndex = 10;
            this.SunnyLbl.Text = "label6";
            // 
            // CloudyLbl
            // 
            this.CloudyLbl.AutoSize = true;
            this.CloudyLbl.Location = new System.Drawing.Point(449, 180);
            this.CloudyLbl.Name = "CloudyLbl";
            this.CloudyLbl.Size = new System.Drawing.Size(35, 13);
            this.CloudyLbl.TabIndex = 11;
            this.CloudyLbl.Text = "label7";
            // 
            // RainyLbl
            // 
            this.RainyLbl.AutoSize = true;
            this.RainyLbl.Location = new System.Drawing.Point(585, 179);
            this.RainyLbl.Name = "RainyLbl";
            this.RainyLbl.Size = new System.Drawing.Size(35, 13);
            this.RainyLbl.TabIndex = 12;
            this.RainyLbl.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 304);
            this.Controls.Add(this.RainyLbl);
            this.Controls.Add(this.CloudyLbl);
            this.Controls.Add(this.SunnyLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DayPeriodLbl);
            this.Controls.Add(this.DayNumbLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DayNumbLbl;
        private System.Windows.Forms.Label DayPeriodLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SunnyLbl;
        private System.Windows.Forms.Label CloudyLbl;
        private System.Windows.Forms.Label RainyLbl;
    }
}

