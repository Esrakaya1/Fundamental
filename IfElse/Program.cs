using System.Linq.Expressions;

namespace IfElse;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        #region  Haftanin Günleri
        // Pazartesi haftanın 1. günü olm üz. ekrandan haftanın gününü okutun.
        // 1=> pazartesi, 2=> salı, ..... 7=> pazar şeklinde bastirin.

        // byte gun;
        // System.Console.WriteLine("gunu giriniz");
        // gun = byte.Parse(Console.ReadLine());

        // if (gun == 1)
        // {
        //     System.Console.WriteLine("Pazartesi");
        // }
        // else if (gun == 2)
        // {
        //     System.Console.WriteLine("Salı");
        // }
        // else if (gun == 3)
        // {
        //     System.Console.WriteLine("Çarşamba");
        // }
        // else if (gun == 4)
        // {
        //     System.Console.WriteLine("Perşembe");
        // }
        // else if (gun == 5)
        // {
        //     System.Console.WriteLine("Cuma");
        // }
        // else if (gun == 6)
        // {
        //     System.Console.WriteLine("Cumartesi");
        // }
        // else if (gun == 7)
        // {
        //     System.Console.WriteLine("Pazar");
        // }
        // else
        // {
        //     System.Console.WriteLine("[1-7] arasında sayı giriniz.");
        // }


        #endregion

        #region Final Notu Bulma

        // byte vize1, vize2, final;
        // double ortalama;


        // System.Console.WriteLine("1. vizeyi giriniz.");
        // vize1 = byte.Parse(Console.ReadLine());
        // System.Console.WriteLine("2. vizeyi giriniz.");
        // vize2 = byte.Parse(Console.ReadLine());
        // System.Console.WriteLine("Final notunu giriniz.");
        // final = byte.Parse(Console.ReadLine());

        // ortalama = (vize1 * 0.15) + (vize2 * 0.15) + (final * 0.7);


        // if (ortalama >= 70 && ortalama <= 100)
        // {
        //     System.Console.WriteLine("A");
        // }
        // else if (ortalama >= 50 && ortalama <= 69)
        // {
        //     System.Console.WriteLine("A");
        // }
        // else if (ortalama >= 29 && ortalama <= 49)
        // {
        //     System.Console.WriteLine("A");
        // }
        // else if (ortalama >= 0 && ortalama <= 28)
        // {
        //     System.Console.WriteLine("A");
        // }

        #endregion

        #region 

        // Console.WriteLine("ürün adi giriniz:");
        // string urun = Console.ReadLine().ToLower();

        // if (urun == "domates" || urun == "biber" || urun == "patlican")
        // {
        //     Console.WriteLine("Bu ürün Sebze Reyonunda bulunmaktadır.");
        // }
        // else if (urun == "diş macunu" || urun == "parfum" || urun == "krem")
        // {
        //     Console.WriteLine("Bu ürün Kozmetik Reyonunda bulunmaktadır.");
        // }
        // else if (urun == "telefon" || urun == "bilgisayar" || urun == "ses sistemi")
        // {
        //     Console.WriteLine("Bu ürün Teknoloji Reyonunda bulunmaktadır.");
        // }
        // else
        // {
        //     Console.WriteLine("Bu ürün bizde yok");
        // }
        #endregion

        #region Fiyat Tespit
        /*
            Urun fiyati:5 Tl olsun
            Disaridan girilecek siparis sayisina gore
            20 de az ise toplam ucretten % 5 indirim yapilacak
            20 - 50 arasinda ise % 10 indirim
            50 - 100 arasinda ise % 15 indirim
            100 ve uzeri icin % 20 indirim yapilsin
            Ekrana Toplam tutar ,indirim miktari ve Odenecek tutar bilgilerini yazdirin
   */

        // byte urunFiyat = 5;
        // System.Console.WriteLine("sipariş sayisi girin.");
        // int siparisSayisi = int.Parse(Console.ReadLine());
        // int toplam = siparisSayisi * 5;

        // if (siparisSayisi < 20)
        // {
        //     System.Console.WriteLine(toplam - (toplam * 0.05));
        // }



        #endregion

        #region Ternary If
        // tek satırda karar mekanizmasi kullanmak istersek ? operatörünü kullanırız.
        // Yazim formati sonuc > 10 ? "true" : "false"

        //int yas = 20;
        //var sonuc = yas > 18 ? "reşit" : "reşit değil";
        //Console.WriteLine(sonuc);
        #endregion

        #region Switch Case
        // if else mantığı ile çalışır.
        // kendi içinde bir indexlemeye sahiptir.
        // eşitlik koşulları fazla olan durumlarda tavsiye edilir.



        #endregion

        #region Ornek1
        // ekrandan mevsim okutun ve ayları okutunuz.

        //Console.WriteLine("mevsim giriniz.");
        //string mevsim = Console.ReadLine().ToLower();

        //switch (mevsim)
        //{
        //    case "kıs":
        //        Console.WriteLine("Aralık, Ocak, Subat");
        //        break;
        //    case "ilkbahar":
        //        Console.WriteLine("mart, nisan, mayıs");
        //        break;
        //    case "yaz":
        //        Console.WriteLine("haziran, temmuz, ağustos");
        //        break;
        //    case "sonbahar":
        //        Console.WriteLine("eylül, ekim, kasım");
        //        break;
        //    default:
        //        Console.WriteLine("düzgün mevsim ismi giriniz.");
        //        break;


        #endregion

        #region Ornek2 Ekrandan rol okutun eğer admin girildiyse admin sayfasına yönlendiriliyorsnuz.
        // admin, ceo, moderatör
        //Console.WriteLine("rol giriniz.");
        //string role = Console.ReadLine().ToLower();

        //switch (role)
        //{
        //    case "satis":
        //    case "finans":
        //    case "lojistik":
        //        Console.WriteLine("satış sayfasına yönlendiriliyorsunuz.");
        //        break;
        //    case "admin":
        //    case "ceo":
        //    case "moderatör":
        //        Console.WriteLine("admin sayfasına yönlendiriliyorsunuz.");
        //        break;
        //    case "üye":
        //    case "member":
        //        Console.WriteLine("üye sayfasına yönlendiriliyorsunuz.");
        //        break;
        //    default:
        //        Console.WriteLine("geçerli bir rol giriniz.");
        //        break;
        //}

        #endregion

        #region Ornek3 Kullanıcı adı ve şifre okutun. Her ikisi doğru ise hosgeldin mesajı.
        // Girilen bilgilerden hangisi yanlış ise onu ekrana yazdır.
        
        //Console.WriteLine("kullanıcı adını giriniz.");
        //string kullanıcı = Console.ReadLine().ToLower();
  
        //Console.WriteLine("şifre giriniz.");
        //string sifre = Console.ReadLine().ToLower();

        //switch (kullanıcı)
        //{
        //    case "admin":
        //        switch (sifre)
        //        {
        //            case "admin":
        //                Console.WriteLine("hosgeldin admin");
        //                break;
        //            default:
        //                Console.WriteLine("kullanıcı doğru sifre yanlış");
        //                break;
        //        }
        //        break;
        //    default:
        //        switch (sifre)
        //        {
        //            case "admin":
        //                Console.WriteLine("sifre doğru kullanıcı yanlış");
        //                break;
        //            default:
        //                Console.WriteLine("girilen bilgilerin hicbiri doğru değil.");
        //                break;
        //        }
            
        //}
        #endregion
    }
    }
