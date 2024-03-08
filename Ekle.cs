using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace SozlukDevVer
{
    public partial class Ekle : Form
    {
        public Ekle()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            textB_Eng.TabIndex = 1;
            textB_Tr.TabIndex = 2;
        }

        private void Ekle_Load(object sender, EventArgs e)
        {
            string VeriTabaniTr = "VeriTabaniTr.txt", VeriTabaniEng = "VeriTabaniEng.txt";
            if (File.Exists(VeriTabaniTr) == true && File.Exists(VeriTabaniEng) == true)
            {
                islem.VeriYaz(ref listB_Tr, ref listB_Eng, Diller.Tr);
                islem.VeriYaz(ref listB_Tr, ref listB_Eng, Diller.Eng);
            }
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textB_Tr.Text == "Türkçe Karşılığını Yazın")
            {
                textB_Tr.Text = "";
                textB_Tr.ForeColor = Color.Black;
            }
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textB_Eng.Text == "İngilizce Karşılığını Yazın")
            {
                textB_Eng.Text = "";
                textB_Eng.ForeColor = Color.Black;
            }
        }
        private void textB_Tr_TextChanged(object sender, EventArgs e)
        {
            textB_Tr.ForeColor = Color.Black;
        }
        private void textB_Eng_TextChanged(object sender, EventArgs e)
        {
            textB_Eng.ForeColor = Color.Black;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            islem.VeriAl(ref textB_Tr,ref textB_Eng);
            islem.VeriYaz(ref listB_Tr, ref listB_Eng, Diller.Tr);
            islem.VeriYaz(ref listB_Tr, ref listB_Eng, Diller.Eng);
            // listB_Tr.TabIndex = listB_Tr.Items.Count - 1;
            // listB_Eng.TabIndex = listB_Eng.Items.Count - 1;
        }

        private void btn_Getir_Click(object sender, EventArgs e)
        {
            char[] Trimlenecekler = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-', ')' };
            textB_Eng.Text = Convert.ToString(listB_Eng.Items[Convert.ToInt32(textB_No.Text)]).Trim(Trimlenecekler);
            textB_Tr.Text = Convert.ToString(listB_Tr.Items[Convert.ToInt32(textB_No.Text)]).Trim(Trimlenecekler);
        }

        private void btn_Degistir_Click(object sender, EventArgs e)
        {
            string VeriTabaniTr = "VeriTabaniTr.txt", VeriTabaniEng = "VeriTabaniEng.txt";
            islem.SatirDegistir(textB_Tr.Text, VeriTabaniTr, Convert.ToInt32(textB_No.Text), listB_Tr);
            islem.SatirDegistir(textB_Eng.Text, VeriTabaniEng, Convert.ToInt32(textB_No.Text), listB_Eng);
            islem.VeriYaz(ref listB_Tr, ref listB_Eng, Diller.Tr);
            islem.VeriYaz(ref listB_Tr, ref listB_Eng, Diller.Eng);
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_SrBnks_Click(object sender, EventArgs e)
        {
            SoruBankasi SB = new SoruBankasi(listB_Tr, listB_Eng);
            SB.ShowDialog();
        }
        
        private void textB_Eng_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textB_Eng_KeyUp(object sender, KeyEventArgs e)
        {
            char[] Trimlenecekler = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-', ')' };
            listB_srch.Items.Clear();
            int syc = listB_Eng.Items.Count;
            for (int i = 0; i < syc; i++)
                if (Regex.IsMatch(Convert.ToString(listB_Eng.Items[i]).Trim(Trimlenecekler).TrimStart('\t'), $"^{textB_Eng.Text}", RegexOptions.IgnoreCase))
                {
                    int klmUzunluk = listB_Eng.Items[i].ToString().Length;
                    if (klmUzunluk > 14)
                    {
                        listB_srch.Items.Add($"{Convert.ToString(listB_Eng.Items[i]).TrimEnd('\t')}\t{Convert.ToString(listB_Tr.Items[i]).Trim(Trimlenecekler).TrimStart('\t')}");
                    }
                    else
                    {
                        listB_srch.Items.Add($"{Convert.ToString(listB_Eng.Items[i]).TrimEnd('\t')}\t\t{Convert.ToString(listB_Tr.Items[i]).Trim(Trimlenecekler).TrimStart('\t')}");
                    }
                }
        }
    }
}

