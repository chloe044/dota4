namespace частицы
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
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.tbSpread = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFromColor = new System.Windows.Forms.Button();
            this.btnToColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpread)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(12, 96);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(771, 423);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(36, 12);
            this.tbDirection.Maximum = 340;
            this.tbDirection.Minimum = 240;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(113, 45);
            this.tbDirection.TabIndex = 2;
            this.tbDirection.TickFrequency = 30;
            this.tbDirection.Value = 300;
            this.tbDirection.Scroll += new System.EventHandler(this.TbDirection_Scroll);
            // 
            // tbSpread
            // 
            this.tbSpread.Location = new System.Drawing.Point(196, 12);
            this.tbSpread.Maximum = 180;
            this.tbSpread.Name = "tbSpread";
            this.tbSpread.Size = new System.Drawing.Size(107, 45);
            this.tbSpread.TabIndex = 3;
            this.tbSpread.TickFrequency = 10;
            this.tbSpread.Value = 180;
            this.tbSpread.Scroll += new System.EventHandler(this.TbSpread_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Направление";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Разброс";
            // 
            // btnFromColor
            // 
            this.btnFromColor.Location = new System.Drawing.Point(368, 13);
            this.btnFromColor.Name = "btnFromColor";
            this.btnFromColor.Size = new System.Drawing.Size(95, 26);
            this.btnFromColor.TabIndex = 6;
            this.btnFromColor.Text = "button1";
            this.btnFromColor.UseVisualStyleBackColor = true;
            this.btnFromColor.Click += new System.EventHandler(this.BtnFromColor_Click);
            // 
            // btnToColor
            // 
            this.btnToColor.Location = new System.Drawing.Point(368, 45);
            this.btnToColor.Name = "btnToColor";
            this.btnToColor.Size = new System.Drawing.Size(95, 26);
            this.btnToColor.TabIndex = 7;
            this.btnToColor.Text = "button2";
            this.btnToColor.UseVisualStyleBackColor = true;
            this.btnToColor.Click += new System.EventHandler(this.BtnToColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 528);
            this.Controls.Add(this.btnToColor);
            this.Controls.Add(this.btnFromColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSpread);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpread)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.TrackBar tbSpread;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFromColor;
        private System.Windows.Forms.Button btnToColor;
    }
}

