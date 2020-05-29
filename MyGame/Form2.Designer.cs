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
            this.gravityTime = new System.Windows.Forms.Timer(this.components);
            this.leftTime = new System.Windows.Forms.Timer(this.components);
            this.rightTime = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Hero = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).BeginInit();
            this.SuspendLayout();
            // 
            // gravityTime
            // 
            this.gravityTime.Enabled = true;
            this.gravityTime.Interval = 1;
            this.gravityTime.Tick += new System.EventHandler(this.timer1_Tick);
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
            // Hero
            // 
            this.Hero.BackColor = System.Drawing.Color.White;
            this.Hero.Location = new System.Drawing.Point(26, 550);
            this.Hero.Name = "Hero";
            this.Hero.Size = new System.Drawing.Size(20, 20);
            this.Hero.TabIndex = 2;
            this.Hero.TabStop = false;
            this.Hero.Tag = "Hero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(253, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(828, 108);
            this.label1.TabIndex = 3;
            this.label1.Text = "Congratulations =)";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(419, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 73);
            this.label2.TabIndex = 4;
            this.label2.Text = "Намжите R";
            this.label2.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1208, 695);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hero);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer gravityTime;
        private System.Windows.Forms.PictureBox Hero;
        private System.Windows.Forms.Timer leftTime;
        private System.Windows.Forms.Timer rightTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}