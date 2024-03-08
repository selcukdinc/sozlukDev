using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SozlukDevVer
{
    enum Diller
    {
        Tr, Eng
    }
    
    class islem
    {
       
        public static void VeriYaz(ref System.Windows.Forms.ListBox LbTr, ref System.Windows.Forms.ListBox LbEng, Diller SeciliDil)
        {
            string VeriTabaniTr = "VeriTabaniTr.txt", VeriTabaniEng = "VeriTabaniEng.txt";
            switch (SeciliDil)
            {
                case Diller.Tr:
                    LbTr.Items.Clear();
                    string metinTr;
                    FileStream fsTr = new FileStream(VeriTabaniTr, FileMode.Open, FileAccess.Read);
                    StreamReader srTr = new StreamReader(fsTr);
                    metinTr = srTr.ReadLine();
                    int siraSayacTr = 0;
                    while (metinTr != null)
                    {
                        LbTr.Items.Add($"{siraSayacTr++}-)\t{metinTr}");
                        metinTr = srTr.ReadLine();
                    }
                    srTr.Close();
                    fsTr.Close();

                    //listBox1.Items.Clear();
                    //string metin;
                    //FileStream fs = new FileStream("VeriTabani.txt", FileMode.Open, FileAccess.Read);
                    //StreamReader sr = new StreamReader(fs);
                    //metin = sr.ReadLine();
                    //int siraSayac = 0;
                    //while (metin != null)
                    //{
                    //    listBox1.Items.Add($"{siraSayac++}-)\t{metin}");
                    //    metin = sr.ReadLine();
                    //}
                    //sr.Close();
                    //fs.Close();

                    // MessageBox.Show("Yazma işlemi başarılı bir şekilde gerçekleşti", "Yazma Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Diller.Eng:
                    LbEng.Items.Clear();
                    string metinEng;
                    FileStream fsEng = new FileStream(VeriTabaniEng, FileMode.Open, FileAccess.Read);
                    StreamReader srEng = new StreamReader(fsEng);
                    metinEng = srEng.ReadLine();
                    int siraSayacEng = 0;
                    while (metinEng != null)
                    {
                        LbEng.Items.Add($"{siraSayacEng++}-)\t{metinEng}");
                        metinEng = srEng.ReadLine();
                    }
                    srEng.Close();
                    fsEng.Close();
                    break;
            }
        }

        public static void VeriAl(ref System.Windows.Forms.TextBox TxTr, ref System.Windows.Forms.TextBox TxEng)
        {
            string VeriTabaniTr = "VeriTabaniTr.txt", VeriTabaniEng = "VeriTabaniEng.txt";
            switch (Kontrol.Yazi(TxTr, TxEng))
            {
                case true: // MessageBox.Show("Kayıt işlemi başarısız oldu", "Kayıt Durumu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); break;
                case false:
                    string metinTr = TxTr.Text;
                    FileStream fsTr = new FileStream(VeriTabaniTr, FileMode.Append, FileAccess.Write);
                    StreamWriter swTr = new StreamWriter(fsTr);
                    swTr.WriteLine(metinTr);
                    swTr.Close();
                    fsTr.Close();
                    TxTr.Text = "";

                    string metinEng = TxEng.Text;
                    FileStream fsEng = new FileStream(VeriTabaniEng, FileMode.Append, FileAccess.Write);
                    StreamWriter swEng = new StreamWriter(fsEng);
                    swEng.WriteLine(metinEng);
                    swEng.Close();
                    fsEng.Close();
                    TxEng.Text = "";

                    //FileStream fs = new FileStream("VeriTabani.txt", FileMode.Append, FileAccess.Write);
                    //StreamWriter sw = new StreamWriter(fs);
                    //sw.WriteLine(metin);
                    //sw.Close();
                    //fs.Close();
                    //textBox1.Text = "";

                    // MessageBox.Show("Kayıt işlemi başarılı bir şekilde gerçekleşti", "Kayıt Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        public static void SatirDegistir(string YeniSatir, string DosyaIsmi, int DegisecekSatirNo, System.Windows.Forms.ListBox Lb)
        {
            switch (Kontrol.Uzunluk(Lb, DegisecekSatirNo))
            {
                case true:// MessageBox.Show("Değiştirme işlemi başarısız oldu", "Değişim Durumu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); break;
                case false:
                    string[] diziSatir = File.ReadAllLines(DosyaIsmi);
                    diziSatir[DegisecekSatirNo] = YeniSatir;
                    File.WriteAllLines(DosyaIsmi, diziSatir);
                    //MessageBox.Show("Değiştirme işlemi başarılı bir şekilde gerçekleşti", "Değişim Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

        }

        public static void SatirlariDegistir(string YeniTr, String YeniEng, string DosyaIsmi, int DegisecekSatirNo, System.Windows.Forms.ListBox LbTr, System.Windows.Forms.ListBox LbEng)
        {
            switch (Kontrol.Uzunluk(LbTr, DegisecekSatirNo) && Kontrol.Uzunluk(LbEng, DegisecekSatirNo))
            {
                case true: MessageBox.Show("Değiştirme işlemi başarısız oldu", "Değişim Durumu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); break;
                case false:
                    SatirDegistir(YeniTr, DosyaIsmi, DegisecekSatirNo, LbTr);
                    SatirDegistir(YeniEng, DosyaIsmi, DegisecekSatirNo, LbEng);
                    break;
            }
        }

        public static int Yerlestirme(System.Windows.Forms.RadioButton C1, System.Windows.Forms.RadioButton C2, System.Windows.Forms.RadioButton C3, System.Windows.Forms.RadioButton C4, System.Windows.Forms.ListBox Lb, int sclnCvp)
        {
            char[] Trimlenecekler = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-', ')' };
            int sinir = Lb.Items.Count;
            Random rastgelesayi = new Random();
            System.Windows.Forms.RadioButton[] Sıklar = new System.Windows.Forms.RadioButton[4];
            Sıklar[0] = C1; Sıklar[1] = C2; Sıklar[2] = C3; Sıklar[3] = C4;
            int DogruCevap = rastgelesayi.Next(0, 4); // 0, 1, 2, 3
            int sayac = 0, cvp = -1;
            int[] SecilenSayilar = new int[3];
            SecilenSayilar[sayac] = rastgelesayi.Next(0, sinir);
            SecilenSayilar[sayac + 1] = rastgelesayi.Next(0, sinir);
            SecilenSayilar[sayac + 2] = rastgelesayi.Next(0, sinir);
            //sclnCvp, 0, 1, 2
            while (SecilenSayilar[sayac] == sclnCvp) SecilenSayilar[sayac] = rastgelesayi.Next(0, sinir);
            while (SecilenSayilar[sayac + 1] == SecilenSayilar[sayac + 0] || SecilenSayilar[sayac + 1] == sclnCvp) SecilenSayilar[sayac + 1] = rastgelesayi.Next(0, sinir);
            while (SecilenSayilar[sayac + 2] == SecilenSayilar[sayac + 0] || SecilenSayilar[sayac + 2] == SecilenSayilar[sayac + 1] || SecilenSayilar[sayac + 2] == sclnCvp) SecilenSayilar[sayac + 2] = rastgelesayi.Next(0, sinir);
            for (int i = 0; i < 4; i++) // 0, 1, 2, 3
            {
                if (i == DogruCevap)
                {
                    Sıklar[i].Text = Lb.Items[sclnCvp].ToString().Trim(Trimlenecekler);
                    cvp = i;
                }
                else
                    Sıklar[i].Text = Lb.Items[SecilenSayilar[sayac++]].ToString().Trim(Trimlenecekler);
            }
            return cvp;
        }
    }
}
