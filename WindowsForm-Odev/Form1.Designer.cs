namespace WindowsForm_Odev
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbIslem = new System.Windows.Forms.TextBox();
            this.tbIlkGiris = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bVirgul = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.bPi = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.tbGiris = new System.Windows.Forms.TextBox();
            this.bTersi = new System.Windows.Forms.Button();
            this.bKare = new System.Windows.Forms.Button();
            this.bKok = new System.Windows.Forms.Button();
            this.bBolu = new System.Windows.Forms.Button();
            this.bCarp = new System.Windows.Forms.Button();
            this.bCıkar = new System.Windows.Forms.Button();
            this.bTopla = new System.Windows.Forms.Button();
            this.bSonuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIslem
            // 
            this.tbIslem.BackColor = System.Drawing.SystemColors.Control;
            this.tbIslem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbIslem.Location = new System.Drawing.Point(482, 60);
            this.tbIslem.Multiline = true;
            this.tbIslem.Name = "tbIslem";
            this.tbIslem.Size = new System.Drawing.Size(142, 78);
            this.tbIslem.TabIndex = 32;
            // 
            // tbIlkGiris
            // 
            this.tbIlkGiris.BackColor = System.Drawing.SystemColors.Control;
            this.tbIlkGiris.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIlkGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbIlkGiris.Location = new System.Drawing.Point(32, 60);
            this.tbIlkGiris.Multiline = true;
            this.tbIlkGiris.Name = "tbIlkGiris";
            this.tbIlkGiris.Size = new System.Drawing.Size(440, 78);
            this.tbIlkGiris.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(482, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bVirgul
            // 
            this.bVirgul.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bVirgul.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bVirgul.Location = new System.Drawing.Point(332, 617);
            this.bVirgul.Name = "bVirgul";
            this.bVirgul.Size = new System.Drawing.Size(142, 88);
            this.bVirgul.TabIndex = 28;
            this.bVirgul.Text = ",";
            this.bVirgul.UseVisualStyleBackColor = false;
            this.bVirgul.Click += new System.EventHandler(this.bVirgul_Click);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b9.Location = new System.Drawing.Point(331, 522);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(142, 88);
            this.b9.TabIndex = 27;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b6.Location = new System.Drawing.Point(331, 428);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(142, 88);
            this.b6.TabIndex = 26;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b3.Location = new System.Drawing.Point(331, 331);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(142, 88);
            this.b3.TabIndex = 25;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b0
            // 
            this.b0.BackColor = System.Drawing.SystemColors.ControlDark;
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b0.Location = new System.Drawing.Point(181, 616);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(142, 88);
            this.b0.TabIndex = 24;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = false;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b8.Location = new System.Drawing.Point(180, 521);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(142, 88);
            this.b8.TabIndex = 23;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b5.Location = new System.Drawing.Point(180, 427);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(142, 88);
            this.b5.TabIndex = 22;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b2.Location = new System.Drawing.Point(180, 330);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(142, 88);
            this.b2.TabIndex = 29;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // bPi
            // 
            this.bPi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bPi.Location = new System.Drawing.Point(33, 617);
            this.bPi.Name = "bPi";
            this.bPi.Size = new System.Drawing.Size(142, 88);
            this.bPi.TabIndex = 21;
            this.bPi.Text = "Pi";
            this.bPi.UseVisualStyleBackColor = false;
            this.bPi.Click += new System.EventHandler(this.bPi_Click);
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b7.Location = new System.Drawing.Point(33, 522);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(142, 88);
            this.b7.TabIndex = 20;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b4.Location = new System.Drawing.Point(32, 428);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(142, 88);
            this.b4.TabIndex = 19;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b1.Location = new System.Drawing.Point(32, 331);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(142, 88);
            this.b1.TabIndex = 18;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // tbGiris
            // 
            this.tbGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbGiris.Location = new System.Drawing.Point(32, 137);
            this.tbGiris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbGiris.Multiline = true;
            this.tbGiris.Name = "tbGiris";
            this.tbGiris.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbGiris.Size = new System.Drawing.Size(441, 89);
            this.tbGiris.TabIndex = 17;
            // 
            // bTersi
            // 
            this.bTersi.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bTersi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bTersi.Location = new System.Drawing.Point(33, 234);
            this.bTersi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bTersi.Name = "bTersi";
            this.bTersi.Size = new System.Drawing.Size(142, 88);
            this.bTersi.TabIndex = 15;
            this.bTersi.Text = "1/x";
            this.bTersi.UseVisualStyleBackColor = false;
            this.bTersi.Click += new System.EventHandler(this.bTersi_Click);
            // 
            // bKare
            // 
            this.bKare.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bKare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bKare.Location = new System.Drawing.Point(184, 234);
            this.bKare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bKare.Name = "bKare";
            this.bKare.Size = new System.Drawing.Size(142, 88);
            this.bKare.TabIndex = 14;
            this.bKare.Text = "x^2";
            this.bKare.UseVisualStyleBackColor = false;
            this.bKare.Click += new System.EventHandler(this.bKare_Click);
            // 
            // bKok
            // 
            this.bKok.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bKok.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bKok.Location = new System.Drawing.Point(332, 235);
            this.bKok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bKok.Name = "bKok";
            this.bKok.Size = new System.Drawing.Size(142, 88);
            this.bKok.TabIndex = 13;
            this.bKok.Text = "x^(1/2)";
            this.bKok.UseVisualStyleBackColor = false;
            this.bKok.Click += new System.EventHandler(this.bKok_Click);
            // 
            // bBolu
            // 
            this.bBolu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bBolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bBolu.Location = new System.Drawing.Point(482, 235);
            this.bBolu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bBolu.Name = "bBolu";
            this.bBolu.Size = new System.Drawing.Size(142, 88);
            this.bBolu.TabIndex = 12;
            this.bBolu.Text = "/";
            this.bBolu.UseVisualStyleBackColor = false;
            this.bBolu.Click += new System.EventHandler(this.bBolu_Click);
            // 
            // bCarp
            // 
            this.bCarp.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bCarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bCarp.Location = new System.Drawing.Point(482, 330);
            this.bCarp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bCarp.Name = "bCarp";
            this.bCarp.Size = new System.Drawing.Size(142, 88);
            this.bCarp.TabIndex = 11;
            this.bCarp.Text = "x";
            this.bCarp.UseVisualStyleBackColor = false;
            this.bCarp.Click += new System.EventHandler(this.bCarp_Click);
            // 
            // bCıkar
            // 
            this.bCıkar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bCıkar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bCıkar.Location = new System.Drawing.Point(482, 426);
            this.bCıkar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bCıkar.Name = "bCıkar";
            this.bCıkar.Size = new System.Drawing.Size(142, 88);
            this.bCıkar.TabIndex = 10;
            this.bCıkar.Text = "-";
            this.bCıkar.UseVisualStyleBackColor = false;
            this.bCıkar.Click += new System.EventHandler(this.bCıkar_Click);
            // 
            // bTopla
            // 
            this.bTopla.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bTopla.Location = new System.Drawing.Point(482, 521);
            this.bTopla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bTopla.Name = "bTopla";
            this.bTopla.Size = new System.Drawing.Size(142, 88);
            this.bTopla.TabIndex = 16;
            this.bTopla.Text = "+";
            this.bTopla.UseVisualStyleBackColor = false;
            this.bTopla.Click += new System.EventHandler(this.bTopla_Click);
            // 
            // bSonuc
            // 
            this.bSonuc.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSonuc.Location = new System.Drawing.Point(482, 616);
            this.bSonuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bSonuc.Name = "bSonuc";
            this.bSonuc.Size = new System.Drawing.Size(142, 88);
            this.bSonuc.TabIndex = 9;
            this.bSonuc.Text = "=";
            this.bSonuc.UseVisualStyleBackColor = false;
            this.bSonuc.Click += new System.EventHandler(this.bSonuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 716);
            this.Controls.Add(this.tbIslem);
            this.Controls.Add(this.tbIlkGiris);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bVirgul);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.bPi);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.tbGiris);
            this.Controls.Add(this.bTersi);
            this.Controls.Add(this.bKare);
            this.Controls.Add(this.bKok);
            this.Controls.Add(this.bBolu);
            this.Controls.Add(this.bCarp);
            this.Controls.Add(this.bCıkar);
            this.Controls.Add(this.bTopla);
            this.Controls.Add(this.bSonuc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIslem;
        private System.Windows.Forms.TextBox tbIlkGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bVirgul;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button bPi;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.TextBox tbGiris;
        private System.Windows.Forms.Button bTersi;
        private System.Windows.Forms.Button bKare;
        private System.Windows.Forms.Button bKok;
        private System.Windows.Forms.Button bBolu;
        private System.Windows.Forms.Button bCarp;
        private System.Windows.Forms.Button bCıkar;
        private System.Windows.Forms.Button bTopla;
        private System.Windows.Forms.Button bSonuc;
    }
}

