using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Kaç adet sayı toplamak istiyorsunuz?");

            //int kacTane = int.Parse(Console.ReadLine());

            //int toplam = 0;

            //double ortalama = 0;

            //for (int i = 0; i < kacTane; i++)
            //{
            //    Console.Write($"{i + 1}. rakamı giriniz:");
            //    toplam += int.Parse(Console.ReadLine());

            //}
            //ortalama = (double)toplam / (double)kacTane;

            //Console.WriteLine($"Girdiğiniz rakamların tolamı : {toplam}");
            //Console.WriteLine($"Girdiğiniz rakamların ortalaması : { ortalama}");


            // V2 


            //int toplam = 0;
            //int fark = 0;
            //int carpim = 0;
            //int bolum = 0;

            //Console.WriteLine("Hangi işlemi yapmak istiyorsunuz ?");
            //Console.WriteLine("1. toplama");
            //Console.WriteLine("2. çıkarma");
            //Console.WriteLine("3. çarpma");
            //Console.WriteLine("4. bölme");

            //int secilenİslem =int.Parse(Console.ReadLine());
            //if (secilenİslem == 1)
            //{
            //    Console.WriteLine(" kaç adet sayı toplamak istiyorsunuz ?");
            //    int adet =int.Parse(Console.ReadLine());
            //    for( int i = 1;  i <= adet; i++ )
            //    {
            //        Console.WriteLine(i  + " . sayıyı giriniz: " );
            //        toplam += int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine("seçilen işem sonucu :" +toplam);


            //}
            //else if (secilenİslem ==2)
            //{
            //    Console.WriteLine("Kaç adet sayının farkını almak istiyorsunıuz ?");
            //    int adet = int.Parse(Console.ReadLine());
            //    for (int i = 1; i <= 1; i++)
            //    {
            //        Console.Write(i + " . sayıyı giriniz: ");
            //        fark += int.Parse(Console.ReadLine());
            //        for (int j = 2; j <= adet; j++)
            //        {
            //            Console.Write(j + " . sayıyı giriniz : ");
            //            fark -= int.Parse(Console.ReadLine());

            //        }

            //    }
            //    Console.WriteLine("seçilen işlemin sonucu :" + fark);
            //}
            //else if (secilenİslem ==3)
            //{
            //    Console.WriteLine("nkaç adet sayının çarpımını almak istiyorsunuz ?");
            //    int adet = int.Parse(Console.ReadLine());
            //    for (int i = 1; i <= 1; i++)
            //    {
            //        Console.Write(i + " . sayıyı giriniz: ");
            //        carpim += int.Parse(Console.ReadLine());

            //        for (int j = 2; j <= adet; j++)
            //        {
            //            Console.WriteLine(j + " . sayıyı giriniz : ");
            //            carpim *= int.Parse(Console.ReadLine());
            //        }

            //    }
            //    Console.WriteLine("seçilen işlem sonucu : " + carpim);
            //}
            //else if (secilenİslem==4)
            //{
            //    Console.WriteLine("kaç adet sayının bölümünü almak istiyorsunuz ?");
            //    int adet = int.Parse(Console.ReadLine());
            //    for (int i = 1; i <= 1; i++)
            //    {
            //        Console.Write(i + " . sayıyı giriniz: ");
            //        bolum += int.Parse(Console.ReadLine());

            //        for (int j = 2; j <= adet; j++)
            //        {
            //            Console.Write(j + " . sayıyı giriniz : ");
            //            bolum /= int.Parse(Console.ReadLine());
            //        }

            //    }
            //    Console.WriteLine("seçilen işlem sonucu : " + bolum);
            //}























            //ALISVERİS 

            //string[] urunler = ["kavun", "şeftali", "elma", "Tuz", "un"];
            //double[] fiyatlar = [3, 6.50, 20, 25, 30];

            //Console.WriteLine("Ürünler:");
            //for (int i = 0; i < urunler.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. {urunler[i]} - {fiyatlar[i]} TL");
            //}

            //Console.WriteLine("Lütfen satın almak istediğiniz ürünün numarasını girin (tüm alışverişi tamamlamak için 't' girin):");

            //double toplamFiyat = 0;


            //while (true)
            //{
            //    string secim = Console.ReadLine();


            //    if (secim.ToLower() == "t")
            //    {
            //        Console.WriteLine($"Toplam Fiyat: {toplamFiyat} TL");
            //        break;
            //    }


            //    if(int.TryParse(secim, out int secilenIndex) && secilenIndex > 0 && secilenIndex <= urunler.Length)
            //    {

            //        string secilenUrun = urunler[secilenIndex - 1];
            //        double urunFiyati = fiyatlar[secilenIndex - 1];
            //        Console.WriteLine($"{secilenUrun} seçildi - {urunFiyati} TL");


            //        toplamFiyat += urunFiyati;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Geçersiz bir seçim yaptınız. Lütfen tekrar deneyin.");
            //    }
            //}





            // TAŞ KAĞIT MAKAS OYUNU 

            int kazanan = 0;
            int kaybeden = 0;
            string kullaniciSecimi;

            while (true)
            {
                Console.WriteLine("Taş, Kağıt veya Makas seçin: ");
                kullaniciSecimi = Console.ReadLine().ToLower();

                string[] secenekler = { "taş", "kağıt", "makas" };
                Random bilgisayarSecimi = new Random();
                string bilgisayarSecim = secenekler[bilgisayarSecimi.Next(secenekler.Length)];

                Console.WriteLine($"Bilgisayar: {bilgisayarSecim}");

                if (kullaniciSecimi == bilgisayarSecim)
                {
                    Console.WriteLine("Berabere!");
                }
                else if (
                    (kullaniciSecimi == "taş" && bilgisayarSecim == "makas") ||
                    (kullaniciSecimi == "kağıt" && bilgisayarSecim == "taş") ||
                    (kullaniciSecimi == "makas" && bilgisayarSecim == "kağıt")
                )
                {
                    kazanan++;
                    Console.WriteLine("Kazandınız!");
                }
                else
                {
                    kaybeden++;
                    Console.WriteLine("Kaybettiniz!");
                }

                Console.WriteLine($"Skor: {kazanan} - {kaybeden}");

                Console.WriteLine("\nTekrar oynamak ister misiniz? (evet/çıkış): ");
                string tekrar = Console.ReadLine().ToLower();

                if (tekrar != "evet")
                {
                    Console.WriteLine("Oyun bitti!");
                    break;
                }











                //QUİİZZZZ



                //Console.WriteLine("Quiz Uygulamasına Hoş Geldiniz.");
                //Console.WriteLine("Soru - Cevap Oyunu için 1'e tıklayınız.");
                //string cevap = Console.ReadLine();

                //if (cevap == "1")
                //{
                //    Console.Clear();

                //    string[] sorular = ["Türkiyenin baskenti ?", "Hangi hayvan, dört bacağı üzerinde yürürken sadece bir ayak izi bırakır?", "Hangi yazar, Savaş ve Barış adlı ünlü romanı yazdı?", "Hangi element, hidrojenin simgesidir?", "Hangi şehir, Ebedi Şehir olarak da bilinir?", "Hangi yıl Berlin Duvarı yıkıldı?"];
                //    string[] secenekler = ["İstanbul|Ankara|İzmir", "fil|zürafa|kaplumbağ", "Anton Çehov|Lev Tolstoy|Fyodor Dostoyevski", "Hi|He|H", "Roma|Atina|İstanbul", "1961|1971|1989"];
                //    string[] cevaplar = ["Ankara", "fil", "Lev Tolstoy", "H", "Roma", "1989"];

                //    for (int i = 0; i < sorular.Length; i++)
                //    {
                //        Console.WriteLine($"Soru {i + 1}: {sorular[i]}");
                //        string[] secenekListesi = secenekler[i].Split('|');
                //        Console.WriteLine("Seçenekler: ");

                //        for (int j = 0; j < secenekListesi.Length; j++)
                //        {
                //            Console.WriteLine($"{j + 1}. {secenekListesi[j]}");
                //        }

                //        Console.Write("Cevabınızı giriniz (1, 2, 3): ");

                //        string inputCevap = Console.ReadLine();
                //        int cevapIndex;

                //        Console.Clear();

                //        if (int.TryParse(inputCevap, out cevapIndex) && cevapIndex > 0 && cevapIndex <= secenekListesi.Length)
                //        {
                //            string secilenCevap = secenekListesi[cevapIndex - 1];
                //            if (secilenCevap == cevaplar[i])
                //            {
                //                Console.WriteLine("Doğru cevapp");
                //            }
                //            else
                //            {
                //                Console.WriteLine($"Yanlış cevap verdiniz. Doğru cevap: {cevaplar[i]}");
                //            }
                //         }






            }
        }
    }

}