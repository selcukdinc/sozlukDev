using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SozlukDevVer
{
    internal class Kontrol
    {
        public static bool Yazi(System.Windows.Forms.TextBox TxBx)
        {
            int sayac = TxBx.Text.Length;
            if (sayac == 0 || TxBx.Text[0] == ' ')
            {
                return true;
            }
            else
            {
                while (sayac > 2)
                {
                    if (TxBx.Text[sayac - 1] == ' ')
                    {
                        int origin = sayac - 1;
                        if (origin + 1 >= TxBx.Text.Length)
                        {
                            if (!(TxBx.Text[origin - 1] == ' '))
                            {
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }
                        else
                        {
                            if (!(TxBx.Text[origin - 1] == ' ') && !(TxBx.Text[origin + 1] == ' '))
                            {
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }
                    }
                    sayac--;
                }
                return false;
            }
        }

        public static bool Yazi(System.Windows.Forms.TextBox TxBx1, System.Windows.Forms.TextBox TxBx2)
        {
            if (Yazi(TxBx1) || Yazi(TxBx2))
                return true;
            return false;
        }

        public static bool Uzunluk(System.Windows.Forms.ListBox Lb1, int SatirNo)
        {
            if (SatirNo > Lb1.Items.Count - 1)
            {
                return true;
            }
            return false;
        }
    }
}
