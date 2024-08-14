namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForDongusu
            // for, while, do-while
            // 1-10 sayılarını bastıralım
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Ornek1 ilk yüz sayının toplamı ve ort ?

            //int toplam = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //    toplam += i;
            //}
            //float ort = toplam / 100f;
            //Console.WriteLine(ort);

            #endregion

            #region 2015-2025 yılları ekrana basınız. Ancak pandemi yıllarını es gecin.

            //for (int i = 2015; i < 2026; i++)
            //{
            //    if (i == 2020)
            //        continue;
            //    Console.WriteLine(i);

            //}
            // dongüyü kırmak için break kullanılır.
            // donguden çıkmak için return kullanılır.
            #endregion

            #region While Dongusu
            // koşul doğru olduğu sürece işlemleri gerçekleştirir.

            // 0 girilene kadar ekrandan okutulan sayıları tolayıp yazdıralım.

            //int toplam = 0, sayi=1,sayac = 0;
            //while (sayi != 0)
            //{
            //    Console.Write("sayi giriniz:");
            //    sayi = int.Parse(Console.ReadLine());
            //    toplam += sayi;
            //    sayac++;
            //}
            //Console.WriteLine($"girilen sayı adedi: {sayac}, toplamı: {toplam}");
            #endregion

            #region Sayı tahmin oyunu: 1-50 arası sayı tutulacak. Kullanıcıya 5 tahmin hakkı verilecek.
            // eğer tutulandan daha büyük bir sayı girilirse daha kucuk bir sayı giriniz mesajı verilsin.
            // eğer tutulandan daha kucuk bir sayı girilirse daha buyuk bir sayı giriniz mesajı verilsin.
            // oyunu bildiyse eğer kacıncı denemede bildiğini yazdırın. 
            // en sonda oyuna devam etmek istiyor musunuz sorusunu alın ve ona göre tekrarlatın.


            //Random rnd = new Random();
            //int tutulansayi = rnd.Next(1,50);
            //byte tahminHakki = 5;

            //while (tutulansayi >)



                #endregion

            #region Fibonacci sayilari 1,1,2,3,5,,8,13,21... kendinden önceki iki sayının toplamı
                // ilk 20 fibonacci sayisini ekrana bastirin.



                #endregion

                #region İlk 20 asal sayiyi yazdirin.

            //    int sayac = 1, altSayac = 0;

            //for(int i= 3; i < 1000; i++ )
            //{
            //    for(int j=1; j< i; j++)
            //    {
            //        if(i%j==0)
            //        {
            //            altSayac++;
            //        }
            //    }
            //}


                #endregion
        }
    }
}
