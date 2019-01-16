namespace NoSleep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chbSvernut = new System.Windows.Forms.CheckBox();
            this.lblVremyaProstoya = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 35);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(165, 70);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chbSvernut
            // 
            this.chbSvernut.AutoSize = true;
            this.chbSvernut.BackColor = System.Drawing.Color.Transparent;
            this.chbSvernut.Checked = true;
            this.chbSvernut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSvernut.Location = new System.Drawing.Point(12, 12);
            this.chbSvernut.Name = "chbSvernut";
            this.chbSvernut.Size = new System.Drawing.Size(126, 17);
            this.chbSvernut.TabIndex = 1;
            this.chbSvernut.Text = "Сворачивать в трей";
            this.chbSvernut.UseVisualStyleBackColor = false;
            // 
            // lblVremyaProstoya
            // 
            this.lblVremyaProstoya.AutoSize = true;
            this.lblVremyaProstoya.Location = new System.Drawing.Point(9, 120);
            this.lblVremyaProstoya.Name = "lblVremyaProstoya";
            this.lblVremyaProstoya.Size = new System.Drawing.Size(35, 13);
            this.lblVremyaProstoya.TabIndex = 2;
            this.lblVremyaProstoya.Text = "label1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "NoSleep остановлен";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NoSleep.Properties.Resources.StartPict;
            this.pictureBox1.Location = new System.Drawing.Point(183, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 140);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblVremyaProstoya);
            this.Controls.Add(this.chbSvernut);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NoSleep";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chbSvernut;
        private System.Windows.Forms.Label lblVremyaProstoya;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

