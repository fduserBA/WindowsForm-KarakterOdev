using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm_KarakterOdev
{
    class BackCode
    {
        public string KarakterKontrol(string metin)
        {
            string turkceKarakterler = "üöşıçğ";
            string ingilizceKarakterler = "uosicg";
            foreach (var harf in metin)
            {
                for (int i = 0; i < turkceKarakterler.Length; i++)
                {
                    if (harf == turkceKarakterler[i])
                    {
                        metin = metin.Replace(harf, ingilizceKarakterler[i]);
                    }
                    else if (harf == turkceKarakterler.ToUpper()[i])
                    {
                        metin = metin.Replace(harf, ingilizceKarakterler.ToUpper()[i]);
                    }
                }
            }
            return metin;
        }
    }
}
