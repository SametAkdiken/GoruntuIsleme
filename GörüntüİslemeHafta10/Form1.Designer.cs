
namespace GörüntüİslemeHafta10
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
            tb_X = new System.Windows.Forms.TextBox();
            tb_Y = new System.Windows.Forms.TextBox();
            tb_Renk = new System.Windows.Forms.TextBox();
            tb_Red = new System.Windows.Forms.TextBox();
            tb_Green = new System.Windows.Forms.TextBox();
            btn_RsmYukle = new System.Windows.Forms.Button();
            btn_GetPiksel = new System.Windows.Forms.Button();
            btn_Temizle = new System.Windows.Forms.Button();
            listBox1 = new System.Windows.Forms.ListBox();
            btn_RenkBul = new System.Windows.Forms.Button();
            btn_RenkIsaretle = new System.Windows.Forms.Button();
            btn_GrayScale = new System.Windows.Forms.Button();
            btn_Bitmap = new System.Windows.Forms.Button();
            lbl_Red = new System.Windows.Forms.Label();
            tb_Blue = new System.Windows.Forms.TextBox();
            lbl_Green = new System.Windows.Forms.Label();
            lbl_Blue = new System.Windows.Forms.Label();
            lbl_X = new System.Windows.Forms.Label();
            lbl_Y = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            pb_Resim = new System.Windows.Forms.PictureBox();
            lbl_Renk = new System.Windows.Forms.Label();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            label1 = new System.Windows.Forms.Label();
            btn_TersSimetri = new System.Windows.Forms.Button();
            btn_Erosion = new System.Windows.Forms.Button();
            btn_Dilation = new System.Windows.Forms.Button();
            lbl_ResimDurum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pb_Resim).BeginInit();
            SuspendLayout();
            // 
            // tb_X
            // 
            tb_X.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb_X.Location = new System.Drawing.Point(403, 107);
            tb_X.Name = "tb_X";
            tb_X.Size = new System.Drawing.Size(125, 30);
            tb_X.TabIndex = 1;
            // 
            // tb_Y
            // 
            tb_Y.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb_Y.Location = new System.Drawing.Point(403, 164);
            tb_Y.Name = "tb_Y";
            tb_Y.Size = new System.Drawing.Size(125, 30);
            tb_Y.TabIndex = 2;
            // 
            // tb_Renk
            // 
            tb_Renk.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb_Renk.Location = new System.Drawing.Point(375, 313);
            tb_Renk.Name = "tb_Renk";
            tb_Renk.Size = new System.Drawing.Size(153, 30);
            tb_Renk.TabIndex = 4;
            // 
            // tb_Red
            // 
            tb_Red.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb_Red.Location = new System.Drawing.Point(657, 32);
            tb_Red.Name = "tb_Red";
            tb_Red.Size = new System.Drawing.Size(125, 30);
            tb_Red.TabIndex = 5;
            // 
            // tb_Green
            // 
            tb_Green.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb_Green.Location = new System.Drawing.Point(657, 76);
            tb_Green.Name = "tb_Green";
            tb_Green.Size = new System.Drawing.Size(125, 30);
            tb_Green.TabIndex = 6;
            // 
            // btn_RsmYukle
            // 
            btn_RsmYukle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_RsmYukle.Location = new System.Drawing.Point(366, 32);
            btn_RsmYukle.Name = "btn_RsmYukle";
            btn_RsmYukle.Size = new System.Drawing.Size(162, 49);
            btn_RsmYukle.TabIndex = 0;
            btn_RsmYukle.Text = "Resim Yükle";
            btn_RsmYukle.UseVisualStyleBackColor = true;
            btn_RsmYukle.Click += btn_RsmYukle_Click;
            // 
            // btn_GetPiksel
            // 
            btn_GetPiksel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_GetPiksel.Location = new System.Drawing.Point(366, 220);
            btn_GetPiksel.Name = "btn_GetPiksel";
            btn_GetPiksel.Size = new System.Drawing.Size(162, 47);
            btn_GetPiksel.TabIndex = 3;
            btn_GetPiksel.Text = "Get Piksel";
            btn_GetPiksel.UseVisualStyleBackColor = true;
            btn_GetPiksel.Click += btn_GetPiksel_Click;
            // 
            // btn_Temizle
            // 
            btn_Temizle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Temizle.Location = new System.Drawing.Point(560, 405);
            btn_Temizle.Name = "btn_Temizle";
            btn_Temizle.Size = new System.Drawing.Size(236, 71);
            btn_Temizle.TabIndex = 17;
            btn_Temizle.Text = "Temizle";
            btn_Temizle.UseVisualStyleBackColor = true;
            btn_Temizle.Click += btn_Temizle_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new System.Drawing.Point(813, 32);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(283, 444);
            listBox1.TabIndex = 8;
            // 
            // btn_RenkBul
            // 
            btn_RenkBul.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_RenkBul.Location = new System.Drawing.Point(560, 180);
            btn_RenkBul.Name = "btn_RenkBul";
            btn_RenkBul.Size = new System.Drawing.Size(109, 50);
            btn_RenkBul.TabIndex = 8;
            btn_RenkBul.Text = "Renk Bul";
            btn_RenkBul.UseVisualStyleBackColor = true;
            btn_RenkBul.Click += btn_RenkBul_Click;
            // 
            // btn_RenkIsaretle
            // 
            btn_RenkIsaretle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_RenkIsaretle.Location = new System.Drawing.Point(687, 180);
            btn_RenkIsaretle.Name = "btn_RenkIsaretle";
            btn_RenkIsaretle.Size = new System.Drawing.Size(109, 50);
            btn_RenkIsaretle.TabIndex = 9;
            btn_RenkIsaretle.Text = "Renk İşaretle";
            btn_RenkIsaretle.UseVisualStyleBackColor = true;
            btn_RenkIsaretle.Click += btn_RenkIsaretle_Click;
            // 
            // btn_GrayScale
            // 
            btn_GrayScale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_GrayScale.Location = new System.Drawing.Point(560, 236);
            btn_GrayScale.Name = "btn_GrayScale";
            btn_GrayScale.Size = new System.Drawing.Size(109, 50);
            btn_GrayScale.TabIndex = 10;
            btn_GrayScale.Text = "Gray Scale";
            btn_GrayScale.UseVisualStyleBackColor = true;
            btn_GrayScale.Click += btn_GrayScale_Click;
            // 
            // btn_Bitmap
            // 
            btn_Bitmap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Bitmap.Location = new System.Drawing.Point(687, 236);
            btn_Bitmap.Name = "btn_Bitmap";
            btn_Bitmap.Size = new System.Drawing.Size(109, 50);
            btn_Bitmap.TabIndex = 11;
            btn_Bitmap.Text = "Bitmap-127";
            btn_Bitmap.UseVisualStyleBackColor = true;
            btn_Bitmap.Click += btn_Bitmap_Click;
            // 
            // lbl_Red
            // 
            lbl_Red.AutoSize = true;
            lbl_Red.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Red.ForeColor = System.Drawing.Color.Red;
            lbl_Red.Location = new System.Drawing.Point(574, 32);
            lbl_Red.Name = "lbl_Red";
            lbl_Red.Size = new System.Drawing.Size(48, 28);
            lbl_Red.TabIndex = 13;
            lbl_Red.Text = "Red";
            // 
            // tb_Blue
            // 
            tb_Blue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb_Blue.Location = new System.Drawing.Point(657, 122);
            tb_Blue.Name = "tb_Blue";
            tb_Blue.Size = new System.Drawing.Size(125, 30);
            tb_Blue.TabIndex = 7;
            // 
            // lbl_Green
            // 
            lbl_Green.AutoSize = true;
            lbl_Green.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Green.ForeColor = System.Drawing.Color.Green;
            lbl_Green.Location = new System.Drawing.Point(574, 70);
            lbl_Green.Name = "lbl_Green";
            lbl_Green.Size = new System.Drawing.Size(68, 28);
            lbl_Green.TabIndex = 13;
            lbl_Green.Text = "Green";
            // 
            // lbl_Blue
            // 
            lbl_Blue.AutoSize = true;
            lbl_Blue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Blue.ForeColor = System.Drawing.Color.Blue;
            lbl_Blue.Location = new System.Drawing.Point(574, 116);
            lbl_Blue.Name = "lbl_Blue";
            lbl_Blue.Size = new System.Drawing.Size(54, 28);
            lbl_Blue.TabIndex = 13;
            lbl_Blue.Text = "Blue";
            // 
            // lbl_X
            // 
            lbl_X.AutoSize = true;
            lbl_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_X.ForeColor = System.Drawing.SystemColors.ControlText;
            lbl_X.Location = new System.Drawing.Point(366, 103);
            lbl_X.Name = "lbl_X";
            lbl_X.Size = new System.Drawing.Size(31, 29);
            lbl_X.TabIndex = 13;
            lbl_X.Text = "X";
            // 
            // lbl_Y
            // 
            lbl_Y.AutoSize = true;
            lbl_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Y.ForeColor = System.Drawing.SystemColors.ControlText;
            lbl_Y.Location = new System.Drawing.Point(366, 164);
            lbl_Y.Name = "lbl_Y";
            lbl_Y.Size = new System.Drawing.Size(30, 29);
            lbl_Y.TabIndex = 13;
            lbl_Y.Text = "Y";
            // 
            // panel1
            // 
            panel1.Location = new System.Drawing.Point(375, 363);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(153, 113);
            panel1.TabIndex = 14;
            // 
            // pb_Resim
            // 
            pb_Resim.Location = new System.Drawing.Point(12, 43);
            pb_Resim.Name = "pb_Resim";
            pb_Resim.Size = new System.Drawing.Size(300, 300);
            pb_Resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pb_Resim.TabIndex = 15;
            pb_Resim.TabStop = false;
            pb_Resim.MouseClick += pb_Resim_MouseClick;
            pb_Resim.MouseMove += pb_Resim_MouseMove;
            // 
            // lbl_Renk
            // 
            lbl_Renk.AutoSize = true;
            lbl_Renk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Renk.ForeColor = System.Drawing.SystemColors.ControlText;
            lbl_Renk.Location = new System.Drawing.Point(420, 285);
            lbl_Renk.Name = "lbl_Renk";
            lbl_Renk.Size = new System.Drawing.Size(51, 20);
            lbl_Renk.TabIndex = 13;
            lbl_Renk.Text = "Renk";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(58, 426);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(154, 28);
            label1.TabIndex = 16;
            label1.Text = "Samet Akdiken";
            // 
            // btn_TersSimetri
            // 
            btn_TersSimetri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_TersSimetri.Location = new System.Drawing.Point(561, 292);
            btn_TersSimetri.Name = "btn_TersSimetri";
            btn_TersSimetri.Size = new System.Drawing.Size(236, 51);
            btn_TersSimetri.TabIndex = 12;
            btn_TersSimetri.Text = "Ters Simetri";
            btn_TersSimetri.UseVisualStyleBackColor = true;
            btn_TersSimetri.Click += btn_TersSimetri_Click;
            // 
            // btn_Erosion
            // 
            btn_Erosion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Erosion.Location = new System.Drawing.Point(561, 349);
            btn_Erosion.Name = "btn_Erosion";
            btn_Erosion.Size = new System.Drawing.Size(109, 50);
            btn_Erosion.TabIndex = 13;
            btn_Erosion.Text = "Erosion";
            btn_Erosion.UseVisualStyleBackColor = true;
            btn_Erosion.Click += btn_Erosion_Click;
            // 
            // btn_Dilation
            // 
            btn_Dilation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Dilation.Location = new System.Drawing.Point(688, 349);
            btn_Dilation.Name = "btn_Dilation";
            btn_Dilation.Size = new System.Drawing.Size(109, 50);
            btn_Dilation.TabIndex = 14;
            btn_Dilation.Text = "Dilation";
            btn_Dilation.UseVisualStyleBackColor = true;
            btn_Dilation.Click += btn_Dilation_Click;
            // 
            // lbl_ResimDurum
            // 
            lbl_ResimDurum.AutoSize = true;
            lbl_ResimDurum.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_ResimDurum.Location = new System.Drawing.Point(82, 8);
            lbl_ResimDurum.Name = "lbl_ResimDurum";
            lbl_ResimDurum.Size = new System.Drawing.Size(148, 29);
            lbl_ResimDurum.TabIndex = 18;
            lbl_ResimDurum.Text = "Resim Durumu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1119, 527);
            Controls.Add(lbl_ResimDurum);
            Controls.Add(label1);
            Controls.Add(pb_Resim);
            Controls.Add(panel1);
            Controls.Add(lbl_Blue);
            Controls.Add(lbl_Renk);
            Controls.Add(lbl_Y);
            Controls.Add(lbl_X);
            Controls.Add(lbl_Green);
            Controls.Add(lbl_Red);
            Controls.Add(btn_Dilation);
            Controls.Add(btn_Erosion);
            Controls.Add(btn_Bitmap);
            Controls.Add(btn_TersSimetri);
            Controls.Add(btn_GrayScale);
            Controls.Add(btn_RenkIsaretle);
            Controls.Add(btn_RenkBul);
            Controls.Add(listBox1);
            Controls.Add(btn_Temizle);
            Controls.Add(btn_GetPiksel);
            Controls.Add(btn_RsmYukle);
            Controls.Add(tb_Blue);
            Controls.Add(tb_Green);
            Controls.Add(tb_Red);
            Controls.Add(tb_Renk);
            Controls.Add(tb_Y);
            Controls.Add(tb_X);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pb_Resim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tb_X;
        private System.Windows.Forms.TextBox tb_Y;
        private System.Windows.Forms.TextBox tb_Renk;
        private System.Windows.Forms.TextBox tb_Red;
        private System.Windows.Forms.TextBox tb_Green;
        private System.Windows.Forms.Button btn_RsmYukle;
        private System.Windows.Forms.Button btn_GetPiksel;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_RenkBul;
        private System.Windows.Forms.Button btn_RenkIsaretle;
        private System.Windows.Forms.Button btn_GrayScale;
        private System.Windows.Forms.Button btn_Bitmap;
        private System.Windows.Forms.Label lbl_Red;
        private System.Windows.Forms.TextBox tb_Blue;
        private System.Windows.Forms.Label lbl_Green;
        private System.Windows.Forms.Label lbl_Blue;
        private System.Windows.Forms.Label lbl_X;
        private System.Windows.Forms.Label lbl_Y;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Resim;
        private System.Windows.Forms.Label lbl_Renk;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TersSimetri;
        private System.Windows.Forms.Button btn_Erosion;
        private System.Windows.Forms.Button btn_Dilation;
        private System.Windows.Forms.Label lbl_ResimDurum;
    }
}

