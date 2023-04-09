using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sifre = "aaaBB!:ca";
            int buyukHarf = 0;
            int kucukHarf = 0;
            char[] isaretler = new char[] { '!', ':', '+', '*' };
            int toplamIsaret = 0;
            if (sifre.Length >= 8)
            {
                foreach (char harf in sifre)
                {
                    if (Convert.ToInt16(harf) >= 65 && Convert.ToInt16(harf) <= 90)
                    {
                        buyukHarf++;
                    }
                    else if (Convert.ToInt16(harf) >= 97 && Convert.ToInt16(harf) <= 122)
                    {
                        kucukHarf++;
                    }
                    else if (isaretler.Contains(harf)==true)
                    {
                        toplamIsaret++;
                    }
                }

                if (buyukHarf >= 2 && kucukHarf >= 3 && toplamIsaret >= 2)
                {
                    Console.WriteLine("Okey");
                }
                else
                {
                    Console.WriteLine("Geçerli zorlukta bir şifre girmediniz!");
                }
            }
        }
    }
}
