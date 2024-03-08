using System;
using System.IO;
using System.Windows.Forms;

namespace SozlukDevVer
{
    public partial class SozlukTestEngine : Form
    {
        public SozlukTestEngine()
        {
            InitializeComponent();
        }

        private void btnKydt_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            switch (Kontrol.Yazi(textBox1))
            {
               case true:
                MessageBox.Show("Kayıt işlemi başarısız oldu", "Kayıt Durumu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Text = "";
                break;
            case false:
                FileStream fs = new FileStream("VeriTabani.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(metin);
                sw.Close();
                fs.Close();
                textBox1.Text = "";
                MessageBox.Show("Kayıt işlemi başarılı bir şekilde gerçekleşti", "Kayıt Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                break;
                }
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string metin;
            FileStream fs = new FileStream("VeriTabani.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            metin = sr.ReadLine();
            int siraSayac = 0;
            while (metin != null)
            {
                listBox1.Items.Add($"{siraSayac++}-)\t{metin}");
                metin = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            MessageBox.Show("Yazma işlemi başarılı bir şekilde gerçekleşti", "Yazma Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGtr_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            string metin;
            FileStream fs = new FileStream("VeriTabani.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            metin = sr.ReadLine();
            while (metin != null)
            {
                listBox1.Items.Add(metin);
                metin = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            listBox2.Items.Add(listBox1.Items[Convert.ToInt32(0+textBox1.Text)]);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Ekle Fe = new Ekle();
            Fe.ShowDialog();
        }
    }
}
