namespace SozlukDevVer
{
    partial class SoruBankasi
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
            this.btn_EkleSil = new System.Windows.Forms.Button();
            this.btnSonra = new System.Windows.Forms.Button();
            this.lblSoru = new System.Windows.Forms.Label();
            this.rdbtC1 = new System.Windows.Forms.RadioButton();
            this.rdbtC2 = new System.Windows.Forms.RadioButton();
            this.rdbtC3 = new System.Windows.Forms.RadioButton();
            this.rdbtC4 = new System.Windows.Forms.RadioButton();
            this.lblSnc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_EkleSil
            // 
            this.btn_EkleSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_EkleSil.Location = new System.Drawing.Point(12, 12);
            this.btn_EkleSil.Name = "btn_EkleSil";
            this.btn_EkleSil.Size = new System.Drawing.Size(169, 35);
            this.btn_EkleSil.TabIndex = 23;
            this.btn_EkleSil.Text = "Ekle - Sil";
            this.btn_EkleSil.UseVisualStyleBackColor = true;
            // 
            // btnSonra
            // 
            this.btnSonra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSonra.Location = new System.Drawing.Point(669, 395);
            this.btnSonra.Name = "btnSonra";
            this.btnSonra.Size = new System.Drawing.Size(119, 43);
            this.btnSonra.TabIndex = 24;
            this.btnSonra.Text = "Sonraki Soru";
            this.btnSonra.UseVisualStyleBackColor = true;
            this.btnSonra.Click += new System.EventHandler(this.btnSonra_Click);
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoru.Location = new System.Drawing.Point(111, 105);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(70, 25);
            this.lblSoru.TabIndex = 25;
            this.lblSoru.Text = "label1";
            // 
            // rdbtC1
            // 
            this.rdbtC1.AutoSize = true;
            this.rdbtC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtC1.Location = new System.Drawing.Point(116, 210);
            this.rdbtC1.Name = "rdbtC1";
            this.rdbtC1.Size = new System.Drawing.Size(152, 29);
            this.rdbtC1.TabIndex = 26;
            this.rdbtC1.TabStop = true;
            this.rdbtC1.Text = "radioButton1";
            this.rdbtC1.UseVisualStyleBackColor = true;
            this.rdbtC1.Click += new System.EventHandler(this.rdbtC4_Click);
            // 
            // rdbtC2
            // 
            this.rdbtC2.AutoSize = true;
            this.rdbtC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtC2.Location = new System.Drawing.Point(116, 245);
            this.rdbtC2.Name = "rdbtC2";
            this.rdbtC2.Size = new System.Drawing.Size(152, 29);
            this.rdbtC2.TabIndex = 27;
            this.rdbtC2.TabStop = true;
            this.rdbtC2.Text = "radioButton1";
            this.rdbtC2.UseVisualStyleBackColor = true;
            this.rdbtC2.Click += new System.EventHandler(this.rdbtC4_Click);
            // 
            // rdbtC3
            // 
            this.rdbtC3.AutoSize = true;
            this.rdbtC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtC3.Location = new System.Drawing.Point(116, 280);
            this.rdbtC3.Name = "rdbtC3";
            this.rdbtC3.Size = new System.Drawing.Size(152, 29);
            this.rdbtC3.TabIndex = 28;
            this.rdbtC3.TabStop = true;
            this.rdbtC3.Text = "radioButton1";
            this.rdbtC3.UseVisualStyleBackColor = true;
            this.rdbtC3.Click += new System.EventHandler(this.rdbtC4_Click);
            // 
            // rdbtC4
            // 
            this.rdbtC4.AutoSize = true;
            this.rdbtC4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtC4.Location = new System.Drawing.Point(116, 315);
            this.rdbtC4.Name = "rdbtC4";
            this.rdbtC4.Size = new System.Drawing.Size(152, 29);
            this.rdbtC4.TabIndex = 29;
            this.rdbtC4.TabStop = true;
            this.rdbtC4.Text = "radioButton1";
            this.rdbtC4.UseVisualStyleBackColor = true;
            this.rdbtC4.Click += new System.EventHandler(this.rdbtC4_Click);
            // 
            // lblSnc
            // 
            this.lblSnc.AutoSize = true;
            this.lblSnc.Location = new System.Drawing.Point(113, 395);
            this.lblSnc.Name = "lblSnc";
            this.lblSnc.Size = new System.Drawing.Size(85, 13);
            this.lblSnc.TabIndex = 30;
            this.lblSnc.Text = "Sorunun cevabı:";
            // 
            // SoruBankasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSnc);
            this.Controls.Add(this.rdbtC4);
            this.Controls.Add(this.rdbtC3);
            this.Controls.Add(this.rdbtC2);
            this.Controls.Add(this.rdbtC1);
            this.Controls.Add(this.lblSoru);
            this.Controls.Add(this.btnSonra);
            this.Controls.Add(this.btn_EkleSil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SoruBankasi";
            this.Text = "Soru Bankası";
            this.Load += new System.EventHandler(this.SoruBankasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EkleSil;
        private System.Windows.Forms.Button btnSonra;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.RadioButton rdbtC1;
        private System.Windows.Forms.RadioButton rdbtC2;
        private System.Windows.Forms.RadioButton rdbtC3;
        private System.Windows.Forms.RadioButton rdbtC4;
        private System.Windows.Forms.Label lblSnc;
    }
}