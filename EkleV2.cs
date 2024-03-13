using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace SozlukDevVer
{
    public partial class EkleV2 : Form
    {
        public EkleV2()
        {
            InitializeComponent();
            InitializeForm();
        }
        private void InitializeForm()
        {
            textB_Eng.TabIndex = 1;
            textB_Tr.TabIndex = 2;
        }
        private void btn_Degistir_Click(object sender, EventArgs e)
        {
            string VeriTabaniTr = "VeriTabaniTr.txt", VeriTabaniEng = "VeriTabaniEng.txt";
            islem.SatirDegistir(textB_Tr.Text, VeriTabaniTr, Convert.ToInt32(textB_No.Text), listB_Tr);
            islem.SatirDegistir(textB_Eng.Text, VeriTabaniEng, Convert.ToInt32(textB_No.Text), listB_Eng);
            islem.VeriYaz(ref listB_Tr, ref listB_Eng, Diller.Tr);
            islem.VeriYaz(ref listB_Tr, ref listB_Eng, Diller.Eng);
        }

        private void textB_Eng_KeyUp(object sender, KeyEventArgs e)
        {
            
            char[] Trimlenecekler = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-', ')','\t' };
            listB_srch.Items.Clear();
            int syc = listB_Eng.Items.Count;
            for (int i = 0; i < syc; i++)
                if (Regex.IsMatch(Convert.ToString(listB_Eng.Items[i]).Trim(Trimlenecekler).TrimStart('\t'), $"^{textB_Eng.Text}", RegexOptions.IgnoreCase))
                {

                    int klmUzunluk = listB_Eng.Items[i].ToString().Trim(Trimlenecekler).Length;
                    //if (i < 10)
                    //{
                    //    klmUzunluk++;
                    //}
                    //else if (i < 100)
                    //{
                    //    klmUzunluk += 2;
                    //}
                    //else
                    //{
                    //    klmUzunluk += 3;
                    //}
                    
                    if (klmUzunluk == 9)
                    {
                        listB_srch.Items.Add($"{Convert.ToString(listB_Eng.Items[i]).TrimEnd('\t')}\t\t|\t{Convert.ToString(listB_Tr.Items[i]).Trim(Trimlenecekler)}");

                    }
                    else if (klmUzunluk > 8)
                    {
                        listB_srch.Items.Add($"{Convert.ToString(listB_Eng.Items[i]).TrimEnd('\t')}\t|\t{Convert.ToString(listB_Tr.Items[i]).Trim(Trimlenecekler)}");

                    }
                    else
                    {
                        listB_srch.Items.Add($"{Convert.ToString(listB_Eng.Items[i]).TrimEnd('\t')}\t\t|\t{Convert.ToString(listB_Tr.Items[i]).Trim(Trimlenecekler)}");
                    }
                }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            islem.VeriAl(ref textB_Tr, ref textB_Eng);
            islem.VeriYaz(ref listB_Tr, ref listB_Eng, Diller.Tr);
            islem.VeriYaz(ref listB_Tr, ref listB_Eng, Diller.Eng);
        }

        private void textB_Tr_TextChanged(object sender, EventArgs e)
        {
            textB_Tr.ForeColor = Color.Black;
        }

        private void textB_Eng_TextChanged(object sender, EventArgs e)
        {
            textB_Eng.ForeColor = Color.Black;
        }

        private void textB_Eng_Click(object sender, EventArgs e)
        {
            if (textB_Eng.Text == "İngilizce Karşılığını Yazın")
            {
                textB_Eng.Text = "";
                textB_Eng.ForeColor = Color.Black;
            }
        }

        private void textB_Tr_Click(object sender, EventArgs e)
        {
            if (textB_Tr.Text == "Türkçe Karşılığını Yazın")
            {
                textB_Tr.Text = "";
                textB_Tr.ForeColor = Color.Black;
            }
        }

        private void EkleV2_Load(object sender, EventArgs e)
        {
            string VeriTabaniTr = "VeriTabaniTr.txt", VeriTabaniEng = "VeriTabaniEng.txt";
            if (File.Exists(VeriTabaniTr) == true && File.Exists(VeriTabaniEng) == true)
            {
                islem.VeriYaz(ref listB_Tr, ref listB_Eng, Diller.Tr);
                islem.VeriYaz(ref listB_Tr, ref listB_Eng, Diller.Eng);
            }
        }

        private void textB_No_KeyUp(object sender, KeyEventArgs e)
        {
            char[] Trimlenecekler = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-', ')', '\t' };
            textB_Eng.Text = "";
            textB_Tr.Text = "";
            string alinanSayi =textB_No.Text;
            Regex r1 = new Regex(@"^([0-9]+$)"), r2 = new Regex(@"^\s?$");
            Match m1 = r1.Match(alinanSayi), m2 = r2.Match(alinanSayi);
            if (m1.Success == true || m2.Success == true)
            {
                int deg = Convert.ToInt32("0"+textB_No.Text), listSayi = listB_Eng.Items.Count;
                if (deg < listSayi)
                {
                    textB_Eng.Text = listB_Eng.Items[Convert.ToInt32(0 + textB_No.Text)].ToString().Trim(Trimlenecekler);
                    textB_Tr.Text = listB_Tr.Items[0 + Convert.ToInt32(0 + textB_No.Text)].ToString().Trim(Trimlenecekler);
                }
                else
                {
                    MessageBox.Show($"Girdiğin sayı {listSayi - 1}'dan büyük olamaz");
                    textB_No.Text = "";
                }
                
            }
            else
            {
                MessageBox.Show("Dostum sadece rakam girebilirsin");
                textB_No.Text = "";
            }
            
        }
    }
}
