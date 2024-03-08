namespace SozlukDevVer
{
    partial class Ekle
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
            this.textB_Tr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textB_Eng = new System.Windows.Forms.TextBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.textB_No = new System.Windows.Forms.TextBox();
            this.btn_Getir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listB_Eng = new System.Windows.Forms.ListBox();
            this.listB_Tr = new System.Windows.Forms.ListBox();
            this.btn_Degistir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_SrBnks = new System.Windows.Forms.Button();
            this.listB_srch = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textB_Tr
            // 
            this.textB_Tr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textB_Tr.ForeColor = System.Drawing.Color.Silver;
            this.textB_Tr.Location = new System.Drawing.Point(388, 138);
            this.textB_Tr.Name = "textB_Tr";
            this.textB_Tr.Size = new System.Drawing.Size(362, 35);
            this.textB_Tr.TabIndex = 0;
            this.textB_Tr.Text = "Türkçe Karşılığını Yazın";
            this.textB_Tr.Click += new System.EventHandler(this.textBox1_Click);
            this.textB_Tr.TextChanged += new System.EventHandler(this.textB_Tr_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(187, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Veritabanına kelime ekleyin veya değiştirin";
            // 
            // textB_Eng
            // 
            this.textB_Eng.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textB_Eng.ForeColor = System.Drawing.Color.Silver;
            this.textB_Eng.Location = new System.Drawing.Point(388, 72);
            this.textB_Eng.Name = "textB_Eng";
            this.textB_Eng.Size = new System.Drawing.Size(362, 35);
            this.textB_Eng.TabIndex = 2;
            this.textB_Eng.Text = "İngilizce Karşılığını Yazın";
            this.textB_Eng.Click += new System.EventHandler(this.textBox2_Click);
            this.textB_Eng.TextChanged += new System.EventHandler(this.textB_Eng_TextChanged);
            this.textB_Eng.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textB_Eng_KeyPress);
            this.textB_Eng.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textB_Eng_KeyUp);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.Location = new System.Drawing.Point(794, 73);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(78, 39);
            this.btn_Ekle.TabIndex = 10;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // textB_No
            // 
            this.textB_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textB_No.ForeColor = System.Drawing.Color.Black;
            this.textB_No.Location = new System.Drawing.Point(885, 142);
            this.textB_No.Name = "textB_No";
            this.textB_No.Size = new System.Drawing.Size(78, 35);
            this.textB_No.TabIndex = 12;
            this.textB_No.Text = "0";
            // 
            // btn_Getir
            // 
            this.btn_Getir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Getir.Location = new System.Drawing.Point(794, 140);
            this.btn_Getir.Name = "btn_Getir";
            this.btn_Getir.Size = new System.Drawing.Size(78, 37);
            this.btn_Getir.TabIndex = 13;
            this.btn_Getir.Text = "Getir";
            this.btn_Getir.UseVisualStyleBackColor = true;
            this.btn_Getir.Click += new System.EventHandler(this.btn_Getir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(399, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Veritabanı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(429, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "İngilizce";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(697, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Türkçe";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listB_Eng
            // 
            this.listB_Eng.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listB_Eng.FormattingEnabled = true;
            this.listB_Eng.ItemHeight = 24;
            this.listB_Eng.Location = new System.Drawing.Point(433, 261);
            this.listB_Eng.Name = "listB_Eng";
            this.listB_Eng.Size = new System.Drawing.Size(262, 196);
            this.listB_Eng.TabIndex = 15;
            // 
            // listB_Tr
            // 
            this.listB_Tr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listB_Tr.FormattingEnabled = true;
            this.listB_Tr.ItemHeight = 24;
            this.listB_Tr.Location = new System.Drawing.Point(701, 262);
            this.listB_Tr.Name = "listB_Tr";
            this.listB_Tr.Size = new System.Drawing.Size(262, 196);
            this.listB_Tr.TabIndex = 14;
            // 
            // btn_Degistir
            // 
            this.btn_Degistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Degistir.Location = new System.Drawing.Point(794, 181);
            this.btn_Degistir.Name = "btn_Degistir";
            this.btn_Degistir.Size = new System.Drawing.Size(78, 37);
            this.btn_Degistir.TabIndex = 19;
            this.btn_Degistir.Text = "Değiştir";
            this.btn_Degistir.UseVisualStyleBackColor = true;
            this.btn_Degistir.Click += new System.EventHandler(this.btn_Degistir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(325, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Türkçe";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(316, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "İngilizce";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_SrBnks
            // 
            this.btn_SrBnks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SrBnks.Location = new System.Drawing.Point(12, 12);
            this.btn_SrBnks.Name = "btn_SrBnks";
            this.btn_SrBnks.Size = new System.Drawing.Size(169, 35);
            this.btn_SrBnks.TabIndex = 22;
            this.btn_SrBnks.Text = "Soru Bankası";
            this.btn_SrBnks.UseVisualStyleBackColor = true;
            this.btn_SrBnks.Click += new System.EventHandler(this.btn_SrBnks_Click);
            // 
            // listB_srch
            // 
            this.listB_srch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listB_srch.FormattingEnabled = true;
            this.listB_srch.ItemHeight = 16;
            this.listB_srch.Location = new System.Drawing.Point(16, 181);
            this.listB_srch.Name = "listB_srch";
            this.listB_srch.Size = new System.Drawing.Size(366, 276);
            this.listB_srch.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "kelime var mı? Bakalım ƪ(˘⌣˘)ʃ";
            // 
            // Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(977, 467);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listB_srch);
            this.Controls.Add(this.btn_SrBnks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Degistir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listB_Eng);
            this.Controls.Add(this.listB_Tr);
            this.Controls.Add(this.btn_Getir);
            this.Controls.Add(this.textB_No);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.textB_Eng);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textB_Tr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ekle";
            this.Text = "Ekle-Sil";
            this.Load += new System.EventHandler(this.Ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textB_Tr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textB_Eng;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.TextBox textB_No;
        private System.Windows.Forms.Button btn_Getir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listB_Eng;
        private System.Windows.Forms.ListBox listB_Tr;
        private System.Windows.Forms.Button btn_Degistir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_SrBnks;
        private System.Windows.Forms.ListBox listB_srch;
        private System.Windows.Forms.Label label7;
    }
}