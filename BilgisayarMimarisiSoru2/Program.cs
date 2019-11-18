using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgisayarMimarisiSoru2
{
    class Program
    {
        static void Main(string[] args)
        {
            int movSayisi = 0;
            int mulSayisi = 0;
            int addSayisi = 0;
            int adcSayisi = 0;
            int incSayisi = 0;
            int cmpSayisi = 0;

            int movCLK = 2;
            int mulCLK = 4;
            int addCLK = 2;
            int adcCLK = 2;
            int incCLK = 2;
            int cmpCLK = 3;


            string dosya_yolu = "../../soru2.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            
            string yazi = sr.ReadLine();
            while (yazi != null)
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
                else if (icerik[0].Equals("INC"))
                {
                    incSayisi++;
                }
                else if (icerik[0].Equals("CMP"))
                {
                    cmpSayisi++;
                }

                yazi = sr.ReadLine();
            }
            sr.Close();
            fs.Close();

            Console.WriteLine("\tKomut\t|\tCLK Sayısı");
            Console.WriteLine("\tMOV\t|\t" + movCLK + "\n" +
                              "\tMUL\t|\t" + mulCLK + "\n" +
                              "\tADD\t|\t" + addCLK + "\n" +
                              "\tADC\t|\t" + adcCLK + "\n" +
                              "\tADC\t|\t" + incCLK + "\n" +
                              "\tADC\t|\t" + cmpCLK + "\n");
            Console.WriteLine("**********************************");
            Console.WriteLine("MOV : " + movSayisi +
                              " MUL : " + mulSayisi +
                              " ADD : " + addSayisi +
                              " ADC : " + adcSayisi +
                              " INC : " + incSayisi +
                              " CMP : " + cmpSayisi);

            Console.WriteLine("**********************************");

            int komut = (movSayisi + mulSayisi + addSayisi + adcSayisi + incSayisi + cmpSayisi);
            int clk = ( movSayisi * movCLK + 
                        mulSayisi * mulCLK + 
                        addSayisi * addCLK + 
                        adcSayisi * adcCLK + 
                        incSayisi * incCLK + 
                        cmpSayisi * cmpCLK);

            double tort = clk / komut;

            for (double i = 1; i <= 5; i += 0.1)
            {
                double t = 1 / i * Math.Pow(10, 9);
                Console.WriteLine("***************************************");
                Console.WriteLine(i + " GHz");
                Console.WriteLine("T ortalama Komut " + (tort * t));
                Console.WriteLine("V " + (1 / (tort * t)));
                Console.WriteLine("***************************************");

                Console.ReadLine();
            }


        }
    }
}
