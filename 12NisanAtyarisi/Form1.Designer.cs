namespace _12NisanAtyarisi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlSaha = new Panel();
            pnlBitis = new Panel();
            at3 = new PictureBox();
            at2 = new PictureBox();
            pictureBox2 = new PictureBox();
            at1 = new PictureBox();
            btnBaslat = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pnlSaha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)at3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)at2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)at1).BeginInit();
            SuspendLayout();
            // 
            // pnlSaha
            // 
            pnlSaha.BackColor = Color.FromArgb(0, 192, 0);
            pnlSaha.Controls.Add(pnlBitis);
            pnlSaha.Controls.Add(at3);
            pnlSaha.Controls.Add(at2);
            pnlSaha.Controls.Add(pictureBox2);
            pnlSaha.Controls.Add(at1);
            pnlSaha.Location = new Point(12, 94);
            pnlSaha.Name = "pnlSaha";
            pnlSaha.Size = new Size(890, 451);
            pnlSaha.TabIndex = 0;
            // 
            // pnlBitis
            // 
            pnlBitis.BackColor = Color.White;
            pnlBitis.Location = new Point(865, 0);
            pnlBitis.Name = "pnlBitis";
            pnlBitis.Size = new Size(10, 448);
            pnlBitis.TabIndex = 5;
            // 
            // at3
            // 
            at3.Image = Properties.Resources.at3;
            at3.Location = new Point(0, 357);
            at3.Name = "at3";
            at3.Size = new Size(100, 67);
            at3.SizeMode = PictureBoxSizeMode.Zoom;
            at3.TabIndex = 4;
            at3.TabStop = false;
            at3.Tag = "3";
            // 
            // at2
            // 
            at2.Image = Properties.Resources.at2;
            at2.Location = new Point(0, 190);
            at2.Name = "at2";
            at2.Size = new Size(100, 67);
            at2.SizeMode = PictureBoxSizeMode.Zoom;
            at2.TabIndex = 3;
            at2.TabStop = false;
            at2.Tag = "2";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(81, 176);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(8, 8);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // at1
            // 
            at1.Image = Properties.Resources.at1;
            at1.Location = new Point(0, 47);
            at1.Name = "at1";
            at1.Size = new Size(100, 67);
            at1.SizeMode = PictureBoxSizeMode.Zoom;
            at1.TabIndex = 1;
            at1.TabStop = false;
            at1.Tag = "1";
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(329, 551);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(207, 29);
            btnBaslat.TabIndex = 1;
            btnBaslat.Text = "YARIŞI BAŞLAT";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnBaslat);
            Controls.Add(pnlSaha);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "At Yarışı";
            pnlSaha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)at3).EndInit();
            ((System.ComponentModel.ISupportInitialize)at2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)at1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSaha;
        private PictureBox at1;
        private PictureBox at3;
        private PictureBox at2;
        private PictureBox pictureBox2;
        private Button btnBaslat;
        private System.Windows.Forms.Timer timer1;
        private Panel pnlBitis;
    }
}