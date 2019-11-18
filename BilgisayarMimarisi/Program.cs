using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgisayarMimarisi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mov = { "0.2", "2" };
            string[] mul = { "0.4", "5" };
            string[] add = { "0.3", "3" };
            string[] adc = { "0.3", "3" };

            int movSayisi = 0;
            int mulSayisi = 0;
            int addSayisi = 0;
            int adcSayisi = 0;
            


            string dosya_yolu = "../../soru1.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string yazi = sr.ReadLine();
            while(yazi != null)
            {
                string[] icerik = yazi.Split(' ');
                if (icerik[0].Equals("MOV"))
                {
                    movSayisi++;
                }
                else if (icerik[0].Equals("MUL"))
                {
                    mulSayisi++;
                }
                else if (icerik[0].Equals("ADD"))
                {
                    addSayisi++;
                }
                else if (icerik[0].Equals("ADC"))
                {
                    adcSayisi++;
                }
                yazi = sr.ReadLine();
            }

            sr.Close();
            fs.Close();
            
            Console.WriteLine("\tKomut\t|\tAğırlık\t|\tCLK Sayısı");
            Console.WriteLine("\tMOV\t|\t" + mov[0] + "\t|\t" + mov[1] + "\n" +
                              "\tMUL\t|\t" + mul[0] + "\t|\t" + mul[1] + "\n" +
                              "\tADD\t|\t" + add[0] + "\t|\t" + add[1] + "\n" +
                              "\tADC\t|\t" + adc[0] + "\t|\t" + adc[1]);
            Console.WriteLine("**********************************");
            Console.WriteLine("MOV : " + movSayisi +
                              " MUL : " + mulSayisi +
                              " ADD : " + addSayisi +
                              " ADC : " + adcSayisi);

            Console.WriteLine("**********************************");
            for (double i = 1; i <= 5; i += 0.1)
            {
                double t = 1 / i * Math.Pow(10, 9);
                Console.WriteLine(t);
                double sonuc = ((movSayisi * double.Parse(mov[0])) + 
                                (mulSayisi * double.Parse(mul[0])) + 
                                (addSayisi * double.Parse(add[0])) + 
                                (adcSayisi * double.Parse(adc[0])))
                    /
                    ((movSayisi * double.Parse(mov[0]) * int.Parse(mov[1]) * t) + 
                    (mulSayisi * double.Parse(mul[0]) * int.Parse(mul[1]) * t) + 
                    (addSayisi * double.Parse(add[0]) * int.Parse(add[1]) * t) + 
                    (adcSayisi * double.Parse(adc[0]) * int.Parse(adc[1]) * t));
                Console.WriteLine(i + " GHz ** " + sonuc);
                Console.ReadLine();
            }
            
        }
    }
}
