namespace MyGame
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.gravityTime = new System.Windows.Forms.Timer(this.components);
            this.Hero = new System.Windows.Forms.PictureBox();
            this.leftTime = new System.Windows.Forms.Timer(this.components);
            this.rightTime = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Tag = "button";
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gravityTime
            // 
            this.gravityTime.Enabled = true;
            this.gravityTime.Interval = 1;
            this.gravityTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Hero
            // 
            this.Hero.BackColor = System.Drawing.Color.White;
            this.Hero.Location = new System.Drawing.Point(91, 191);
            this.Hero.Name = "Hero";
            this.Hero.Size = new System.Drawing.Size(42, 39);
            this.Hero.TabIndex = 2;
            this.Hero.TabStop = false;
            this.Hero.Tag = "Hero";
            // 
            // leftTime
            // 
            this.leftTime.Interval = 1;
            this.leftTime.Tick += new System.EventHandler(this.leftTime_Tick);
            // 
            // rightTime
            // 
            this.rightTime.Interval = 1;
            this.rightTime.Tick += new System.EventHandler(this.rightTime_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1208, 695);
            this.Controls.Add(this.Hero);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer gravityTime;
        private System.Windows.Forms.PictureBox Hero;
        private System.Windows.Forms.Timer leftTime;
        private System.Windows.Forms.Timer rightTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}