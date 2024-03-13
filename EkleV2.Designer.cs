namespace SozlukDevVer
{
    partial class EkleV2
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
            this.listB_srch = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textB_No = new System.Windows.Forms.TextBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.textB_Eng = new System.Windows.Forms.TextBox();
            this.textB_Tr = new System.Windows.Forms.TextBox();
            this.btn_Degistir = new System.Windows.Forms.Button();
            this.listB_Eng = new System.Windows.Forms.ListBox();
            this.listB_Tr = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listB_srch
            // 
            this.listB_srch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listB_srch.FormattingEnabled = true;
            this.listB_srch.ItemHeight = 16;
            this.listB_srch.Location = new System.Drawing.Point(5, 193);
            this.listB_srch.Name = "listB_srch";
            this.listB_srch.Size = new System.Drawing.Size(469, 276);
            this.listB_srch.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "İngilizce";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Türkçe";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textB_No
            // 
            this.textB_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textB_No.ForeColor = System.Drawing.Color.Black;
            this.textB_No.Location = new System.Drawing.Point(300, 124);
            this.textB_No.Name = "textB_No";
            this.textB_No.Size = new System.Drawing.Size(78, 35);
            this.textB_No.TabIndex = 27;
            this.textB_No.Text = "0";
            this.textB_No.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textB_No_KeyUp);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.Location = new System.Drawing.Point(132, 124);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(78, 37);
            this.btn_Ekle.TabIndex = 26;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // textB_Eng
            // 
            this.textB_Eng.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textB_Eng.ForeColor = System.Drawing.Color.Silver;
            this.textB_Eng.Location = new System.Drawing.Point(5, 22);
            this.textB_Eng.Name = "textB_Eng";
            this.textB_Eng.Size = new System.Drawing.Size(469, 35);
            this.textB_Eng.TabIndex = 25;
            this.textB_Eng.Text = "İngilizce Karşılığını Yazın";
            this.textB_Eng.Click += new System.EventHandler(this.textB_Eng_Click);
            this.textB_Eng.TextChanged += new System.EventHandler(this.textB_Eng_TextChanged);
            this.textB_Eng.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textB_Eng_KeyUp);
            // 
            // textB_Tr
            // 
            this.textB_Tr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textB_Tr.ForeColor = System.Drawing.Color.Silver;
            this.textB_Tr.Location = new System.Drawing.Point(5, 83);
            this.textB_Tr.Name = "textB_Tr";
            this.textB_Tr.Size = new System.Drawing.Size(469, 35);
            this.textB_Tr.TabIndex = 24;
            this.textB_Tr.Text = "Türkçe Karşılığını Yazın";
            this.textB_Tr.Click += new System.EventHandler(this.textB_Tr_Click);
            this.textB_Tr.TextChanged += new System.EventHandler(this.textB_Tr_TextChanged);
            // 
            // btn_Degistir
            // 
            this.btn_Degistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Degistir.Location = new System.Drawing.Point(216, 124);
            this.btn_Degistir.Name = "btn_Degistir";
            this.btn_Degistir.Size = new System.Drawing.Size(78, 37);
            this.btn_Degistir.TabIndex = 32;
            this.btn_Degistir.Text = "Değiştir";
            this.btn_Degistir.UseVisualStyleBackColor = true;
            this.btn_Degistir.Click += new System.EventHandler(this.btn_Degistir_Click);
            // 
            // listB_Eng
            // 
            this.listB_Eng.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listB_Eng.FormattingEnabled = true;
            this.listB_Eng.ItemHeight = 24;
            this.listB_Eng.Location = new System.Drawing.Point(109, 232);
            this.listB_Eng.Name = "listB_Eng";
            this.listB_Eng.Size = new System.Drawing.Size(262, 196);
            this.listB_Eng.TabIndex = 34;
            this.listB_Eng.Visible = false;
            // 
            // listB_Tr
            // 
            this.listB_Tr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listB_Tr.FormattingEnabled = true;
            this.listB_Tr.ItemHeight = 24;
            this.listB_Tr.Location = new System.Drawing.Point(109, 232);
            this.listB_Tr.Name = "listB_Tr";
            this.listB_Tr.Size = new System.Drawing.Size(262, 196);
            this.listB_Tr.TabIndex = 33;
            this.listB_Tr.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(8, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 24);
            this.label7.TabIndex = 35;
            this.label7.Text = "kelime var mı? Bakalım ƪ(˘⌣˘)ʃ";
            // 
            // EkleV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 478);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listB_Eng);
            this.Controls.Add(this.listB_Tr);
            this.Controls.Add(this.btn_Degistir);
            this.Controls.Add(this.listB_srch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textB_No);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.textB_Eng);
            this.Controls.Add(this.textB_Tr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EkleV2";
            this.Text = "EkleV2";
            this.Load += new System.EventHandler(this.EkleV2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listB_srch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textB_No;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.TextBox textB_Eng;
        private System.Windows.Forms.TextBox textB_Tr;
        private System.Windows.Forms.Button btn_Degistir;
        private System.Windows.Forms.ListBox listB_Eng;
        private System.Windows.Forms.ListBox listB_Tr;
        private System.Windows.Forms.Label label7;
    }
}