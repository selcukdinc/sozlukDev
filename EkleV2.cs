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
    }
}
