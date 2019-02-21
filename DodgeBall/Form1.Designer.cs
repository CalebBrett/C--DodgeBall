namespace DodgeBall
{
    partial class Form1
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
            this.lvl = new System.Windows.Forms.Timer(this.components);
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.ball1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ball3 = new System.Windows.Forms.PictureBox();
            this.ball4 = new System.Windows.Forms.PictureBox();
            this.ball5 = new System.Windows.Forms.PictureBox();
            this.ball2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ball1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball2)).BeginInit();
            this.SuspendLayout();
            // 
            // lvl
            // 
            this.lvl.Enabled = true;
            this.lvl.Interval = 5000;
            this.lvl.Tick += new System.EventHandler(this.lvl_Tick);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 30;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // ball1
            // 
            this.ball1.BackColor = System.Drawing.Color.Red;
            this.ball1.Location = new System.Drawing.Point(73, 642);
            this.ball1.Name = "ball1";
            this.ball1.Size = new System.Drawing.Size(30, 30);
            this.ball1.TabIndex = 0;
            this.ball1.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Lime;
            this.player.Location = new System.Drawing.Point(749, 225);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(45, 45);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ball1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ball3);
            this.panel1.Controls.Add(this.ball4);
            this.panel1.Controls.Add(this.ball5);
            this.panel1.Controls.Add(this.ball2);
            this.panel1.Controls.Add(this.player);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1362, 700);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(625, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // ball3
            // 
            this.ball3.BackColor = System.Drawing.Color.Red;
            this.ball3.Location = new System.Drawing.Point(241, 91);
            this.ball3.Name = "ball3";
            this.ball3.Size = new System.Drawing.Size(30, 30);
            this.ball3.TabIndex = 5;
            this.ball3.TabStop = false;
            // 
            // ball4
            // 
            this.ball4.BackColor = System.Drawing.Color.Red;
            this.ball4.Location = new System.Drawing.Point(1119, 91);
            this.ball4.Name = "ball4";
            this.ball4.Size = new System.Drawing.Size(30, 30);
            this.ball4.TabIndex = 4;
            this.ball4.TabStop = false;
            // 
            // ball5
            // 
            this.ball5.BackColor = System.Drawing.Color.Red;
            this.ball5.Location = new System.Drawing.Point(916, 545);
            this.ball5.Name = "ball5";
            this.ball5.Size = new System.Drawing.Size(30, 30);
            this.ball5.TabIndex = 3;
            this.ball5.TabStop = false;
            // 
            // ball2
            // 
            this.ball2.BackColor = System.Drawing.Color.Red;
            this.ball2.Location = new System.Drawing.Point(467, 376);
            this.ball2.Name = "ball2";
            this.ball2.Size = new System.Drawing.Size(30, 30);
            this.ball2.TabIndex = 2;
            this.ball2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 702);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ball1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ball1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox ball2;
        private System.Windows.Forms.PictureBox ball3;
        private System.Windows.Forms.PictureBox ball4;
        private System.Windows.Forms.PictureBox ball5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer lvl;
    }
}

