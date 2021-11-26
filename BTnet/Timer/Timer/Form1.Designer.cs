﻿
namespace Timer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbtimers = new System.Windows.Forms.Label();
            this.btbatdau = new System.Windows.Forms.Button();
            this.btketthuc = new System.Windows.Forms.Button();
            this.lbtimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Nbtimer = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Nbtimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtimers
            // 
            this.lbtimers.AutoSize = true;
            this.lbtimers.Location = new System.Drawing.Point(109, 57);
            this.lbtimers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtimers.Name = "lbtimers";
            this.lbtimers.Size = new System.Drawing.Size(96, 17);
            this.lbtimers.TabIndex = 0;
            this.lbtimers.Text = "Thời gian (m):";
            // 
            // btbatdau
            // 
            this.btbatdau.Location = new System.Drawing.Point(209, 90);
            this.btbatdau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btbatdau.Name = "btbatdau";
            this.btbatdau.Size = new System.Drawing.Size(160, 28);
            this.btbatdau.TabIndex = 2;
            this.btbatdau.Text = "Bắt đầu";
            this.btbatdau.UseVisualStyleBackColor = true;
            this.btbatdau.Click += new System.EventHandler(this.btbatdau_Click);
            // 
            // btketthuc
            // 
            this.btketthuc.Location = new System.Drawing.Point(209, 127);
            this.btketthuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btketthuc.Name = "btketthuc";
            this.btketthuc.Size = new System.Drawing.Size(160, 28);
            this.btketthuc.TabIndex = 3;
            this.btketthuc.Text = "Kết thúc";
            this.btketthuc.UseVisualStyleBackColor = true;
            this.btketthuc.Click += new System.EventHandler(this.btketthuc_Click);
            // 
            // lbtimer
            // 
            this.lbtimer.AutoSize = true;
            this.lbtimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtimer.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbtimer.Location = new System.Drawing.Point(488, 39);
            this.lbtimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtimer.Name = "lbtimer";
            this.lbtimer.Size = new System.Drawing.Size(363, 170);
            this.lbtimer.TabIndex = 4;
            this.lbtimer.Text = "1:30";
            this.lbtimer.Click += new System.EventHandler(this.lbtimer_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Nbtimer
            // 
            this.Nbtimer.Location = new System.Drawing.Point(209, 57);
            this.Nbtimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nbtimer.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.Nbtimer.Name = "Nbtimer";
            this.Nbtimer.Size = new System.Drawing.Size(160, 22);
            this.Nbtimer.TabIndex = 5;
            this.Nbtimer.ThousandsSeparator = true;
            this.Nbtimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nbtimer.ValueChanged += new System.EventHandler(this.Nbtimer_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 193);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(13, 12);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 620);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Nbtimer);
            this.Controls.Add(this.lbtimer);
            this.Controls.Add(this.btketthuc);
            this.Controls.Add(this.btbatdau);
            this.Controls.Add(this.lbtimers);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Famer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Nbtimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtimers;
        private System.Windows.Forms.Button btbatdau;
        private System.Windows.Forms.Button btketthuc;
        private System.Windows.Forms.Label lbtimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown Nbtimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

