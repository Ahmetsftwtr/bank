using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace bank
{
    class Program
    {

        public static int bakiye = 500;
        public static int limit = bakiye*50/100;
        

        public static String kullanici;

        public static String sifre;

        public static String cardno = string.Empty;


        static void Main(string[] args)
        {

            int secim;
            int bakiyekle;
            int bakiyecek;




            Console.Write("Hoşgeldiniz lütfen isminizi giriniz : ");
            kullanici += Console.ReadLine();


            Console.Write("Hesab şifrenizi oluşturun : ");
            sifre += Console.ReadLine();




            Console.Clear();


           

            hesap:
            Console.WriteLine("Merhaba, " + kullanici);

            Console.WriteLine("Hesap bakiyeniz : " + bakiye);
            Console.WriteLine("Günlük çekim limitiniz : " + limit);

            if (cardno == "")
            {
                Console.WriteLine("Card numaranız : " + Carduretici(16));
            }
            else
            {
                Console.WriteLine("Card numaranız : " + cardno);

            }

            Console.WriteLine("-----------------------------------------------------------------------------");

            Console.WriteLine("1 - Hesabıma Bakiye Ekle");
            Console.WriteLine("2 - Hesabımdan Bakiye Çekimi Yap");
            Console.WriteLine("3 - Şifremi değiştir");

            Console.Write("Seçiminiz : ");

            secim = Convert.ToInt16(Console.ReadLine());

            

            switch(secim)
            {


                case 1:
                    Console.Clear();
                    Console.WriteLine("Unutmayin Tek Seferde Sadece 1000 TL Yatırabilirsiniz.");
                    Console.Write("Ne kadar eklemek yapmak istiyorsunuz : ");
                    bakiyekle = Convert.ToInt16(Console.ReadLine());

                    if (bakiyekle <= 1000)
                    {
                        bakiye += bakiyekle;
                        Console.Clear();
                        Console.WriteLine("--------------- Tutar başarıyla eklendi -----------------");
                        goto hesap;
                    }
                    else

                    {
                        Console.Clear();
                      Console.WriteLine(" ---------------- Lütfen tek seferlik limiti aşmayın. -------------------");
                        goto hesap;
                    }

                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Lütfen Günlük Çekim Limitini Aşmayınız !");
                    Console.Write("Ne kadar çekim yapmak istiyorsunuz : ");
                    bakiyecek = Convert.ToInt16(Console.ReadLine());

                    if(bakiyecek <= limit)
                    {

                        bakiye -= bakiyecek;
                        Console.Clear();
                        Console.WriteLine("--------------- Tutar başarıyla Çekildi -----------------");
                        goto hesap;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(" ---------------- Lütfen Günlük Çekim Limitini Aşmayın. -------------------");
                        goto hesap;

                    }



                    break;

                case 3:

                    sifredegister:

                    Console.Clear();
                    Console.Write("Şifrenizi değiştirmek istiyormusunuz ? (Y/N) : ");
                    String cevap = Console.ReadLine();
                    if(cevap == "Y")
                    {
                        SifreY:
                        Console.Write("Yeni Şifrenizi Giriniz : ");
                       String sifre1 = Console.ReadLine();
                        Console.Write("Yeni Şifrenizi  Tekrar  Giriniz : ");
                        String sifre2 = Console.ReadLine();


                        if(sifre1 == sifre2)
                        {

                            sifre = "";
                            sifre += sifre1;
                            Console.Clear();
                            Console.WriteLine(" --------  Şifreniz Başarıyla Değiştirildi -----------");


                            goto hesap;

                        }
                        else
                        {


                            Console.WriteLine("Şifreler Birbiriyle uyuşmuyor Tekrar Deneyin");
                            goto SifreY;
                        }


                    }

                    else if(cevap == "N")
                    {


                        Console.Clear();

                        
                        Console.WriteLine(" ---------- Şifre değişikliği iptal edildi ------------------");

                        goto hesap;
                        

                    }
                    else
                    {

                        Console.Clear();

                        goto sifredegister;

                    }

                    break;



            }
         



            Console.ReadKey();

        }


        public static String Carduretici(int size)
        {

            Random cardnouret = new Random();

            for (int i = 0; i < size; i++)
            {


                    cardno += cardnouret.Next(1, 9);
                


            }

            return cardno;


        }





    }
}
