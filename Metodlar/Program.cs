namespace Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Konu Anlatimi
            /*
             * Metod Nedir : Belirli bir işlevi yerine yetirmek icin kullanilan bir kod blogudur
             * Metodlarin tipleri => geriye deger donen yada donmeyen metodlar 
             *                       Eger metodlar geriye deger donmeyecek ise void olarak isaretlenmek zorundadir.
             *                       Eger DEger Donecek ise tipi belirtmek zorundadir.
             * Butun metodlar parametrik şekilde olabilir.
             * Yani bir meyoda tipini belirtmek şarti ile istediginiz kadar parametre gonderebilirsiniz.
             * 
             * Faydalari : Kodun tekrarini engeller. Tekrar kullanimi saglar
             * Kodun okunakligini arttirir. Programi daha moduler hale getirir.
             * 
             * Tanimlama Sekli 
             * 
             * [Erişim belirteci] [Geri Donus Tipi] [MetodAdi](aldigi parametreler) 
             * {
             *    Kodlar buraya...
             * }
             * 
             * [Erişim belirteci] => metoda kimlerin ulasabilecegini belirler 
             *                       public , private ,internal protected seklinde degerler alabilir.
             *                       public => genel kullanima acik demek. Simdilik bunu kullanacagiz.
             * 
             * [Geri Donus Tipi] => Eger bir sey donmeyecekse void olarak isaretlenmelidir.
             *                      Donus tipi int,float,string,datetime v.b.. degerler donebilir.
             *                      Eger geri donus tipi tanimliyse metod sonunda mutlaka return ifadesi olmak zorundadir.
             *                      
             * (aldigi parametreler) => metoda gondermek istedigimiz verilerdir. Ayrac olarak , ile ayrilirlar
             *                          MEtoda gelecek olan parametrelerin mutlaka tiplerinin de yazilmasi zorunludur.
             *  Metodlarin tanimlandigi yerler genelde  class icerisindedir.                     
             */
            #endregion

            #region Metod imzasi.
            /*
             * Aldgi parametreler farkli oldugu surece ayni isimde metod yazilabilir.
             * Buna metod overload yani aşırı yuklenmesi denir.
             * 
             * Metodun geri donus tipi imzaya dahil degildir.
             * 
             * 
             */

            #endregion

            #region iki Sayiyi toplayacak metod 
            // public static void Topla(int sayi1,int sayi2)
            // public static long Topla(int sayi1,int sayi2)

            #endregion

            #region Metod Cagrimi
            //Topla(3, 5);
            //decimal toplam = Topla(3.5m, 5.3m);
            //Console.WriteLine($"Float Toplam:{toplam.ToString("0.00")}");
            #endregion

        }
        //public static void Topla(int sayi1, int sayi2)
        //{
        //    Console.WriteLine($"Toplam:{sayi1 + sayi2}");
        //}
        //public static long Topla(long sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}
        //public static int Topla(byte sayi1, byte sayi2)
        //{
        //    return sayi1 + sayi2;
        //}
        //public static int Topla(short sayi1, short sayi2)
        //{
        //    return sayi1 + sayi2;
        //}
        //public static long Topla(long sayi1, long sayi2)
        //{
        //    return sayi1 + sayi2;
        //}
        //public static float Topla(float sayi1, float sayi2)
        //{
        //    return sayi1 + sayi2;
        //}
        //public static double Topla(double sayi1, double sayi2)
        //{
        //    return sayi1 + sayi2;
        //}
        ///// <summary>
        ///// Gelen iki decimal sayiyi toplar ve sonucu geri doner.
        ///// </summary>
        ///// <param name="sayi1">Decimal tipinden olmalidir </param>
        ///// <param name="sayi2">Decimal tipinden olmalidir</param>
        ///// <returns>Geriye decimal doner</returns>
        //public static decimal Topla(decimal sayi1, decimal sayi2)
        //{
        //    return sayi1 + sayi2;
        //}
        
        //public static void SayiOku(string mesaj)
        //{
        //    int sayi;
        //    bool sonuc = true;
        //    do
        //    {
        //        Console.WriteLine(mesaj);
        //        sonuc = int.TryParse(Console.ReadLine(), out sayi);
        //    } while (!sonuc) ;
        //    return sayi;

        }
       
    }
}
