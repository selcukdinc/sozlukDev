using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SozlukDevVer
{
    public partial class SoruBankasi : Form
    {
        ListBox Lbtr;
        ListBox Lbeng;
        char[] Trimlenecekler = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-', ')' };
        public SoruBankasi(System.Windows.Forms.ListBox ListTr, System.Windows.Forms.ListBox ListEng)
        {
            InitializeComponent();
            Lbtr = ListTr;
            Lbeng = ListEng;
        }
        int CVP = -1;
        private void SoruBankasi_Load(object sender, EventArgs e)
        {
            int sinir = Lbtr.Items.Count;
            Random rastgelesayi = new Random();
            int SecilenSoru = rastgelesayi.Next(0, sinir);
            lblSoru.Text = $"{Lbtr.Items[SecilenSoru].ToString().Trim(Trimlenecekler)} Kelimesinin ingilizce karşılığı nedir?";
            CVP = islem.Yerlestirme(rdbtC1, rdbtC2, rdbtC3, rdbtC4, Lbeng, SecilenSoru);
        }
        
        System.Windows.Forms.RadioButton[] rdCs = new System.Windows.Forms.RadioButton[4];
        int[] ScSoruNum = new int[5];
        int ScSoruNumSyc = 0;
        private void btnSonra_Click(object sender, EventArgs e)
        {
            int sinir = Lbtr.Items.Count;
            Random rastgelesayi = new Random();
            // Soru: 0, 1, 2, 3, 4
            switch (ScSoruNumSyc)
            {
                case 0:
                    ScSoruNum[ScSoruNumSyc] = rastgelesayi.Next(0, sinir);
                    break;
                case 1:
                    do
                    {
                        ScSoruNum[ScSoruNumSyc] = rastgelesayi.Next(0, sinir);
                    } while (ScSoruNum[ScSoruNumSyc] == ScSoruNum[ScSoruNumSyc - 1]);
                    break;
                case 2:
                    do
                    {
                        ScSoruNum[ScSoruNumSyc] = rastgelesayi.Next(0, sinir);
                    } while (ScSoruNum[ScSoruNumSyc] == ScSoruNum[ScSoruNumSyc - 1] || ScSoruNum[ScSoruNumSyc] == ScSoruNum[ScSoruNumSyc - 2]);
                    break;
                case 3:
                    do
                    {
                        ScSoruNum[ScSoruNumSyc] = rastgelesayi.Next(0, sinir);
                    } while (ScSoruNum[ScSoruNumSyc] == ScSoruNum[ScSoruNumSyc - 1] || ScSoruNum[ScSoruNumSyc] == ScSoruNum[ScSoruNumSyc - 2] || ScSoruNum[ScSoruNumSyc] == ScSoruNum[ScSoruNumSyc - 3]);
                    break;
                case 4:
                    do
                    {
                        ScSoruNum[ScSoruNumSyc] = rastgelesayi.Next(0, sinir);
                    } while (ScSoruNum[ScSoruNumSyc] == ScSoruNum[ScSoruNumSyc - 1] || ScSoruNum[ScSoruNumSyc] == ScSoruNum[ScSoruNumSyc - 2] || ScSoruNum[ScSoruNumSyc] == ScSoruNum[ScSoruNumSyc - 3] || ScSoruNum[ScSoruNumSyc] == ScSoruNum[ScSoruNumSyc - 4]);
                    break;
            }

            lblSoru.Text = $"{Lbtr.Items[ScSoruNum[ScSoruNumSyc]].ToString().Trim(Trimlenecekler)} Kelimesinin ingilizce karşılığı nedir?";
            CVP = islem.Yerlestirme(rdbtC1, rdbtC2, rdbtC3, rdbtC4, Lbeng, ScSoruNum[ScSoruNumSyc]);
            rdCs[0] = rdbtC1; rdCs[1] = rdbtC2; rdCs[2] = rdbtC3; rdCs[3] = rdbtC4;
            rdbtC1.Checked = true;
            rdbtC1.Checked = false;
            lblSnc.Text = "Sorunun cevabı: ?";
            ScSoruNumSyc++;
            if (ScSoruNumSyc == 5)
            {
                ScSoruNumSyc = 0;
                
            }
        }

        private void rdbtC4_Click(object sender, EventArgs e)
        {
            rdCs[0] = rdbtC1; rdCs[1] = rdbtC2; rdCs[2] = rdbtC3; rdCs[3] = rdbtC4;
            if (rdCs[CVP].Checked == true)
            {
                lblSnc.Text = "Sorunun cevabı: doğru";
            }
            else
                lblSnc.Text = "Sorunun cevabı: yanlış";
        }
    }
}
