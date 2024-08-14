namespace Diziler
{
    internal class Program
    {
        private static object rnd;

        static void Main(string[] args)
        {

            #region Dizideki en küçük ve en büyük elemanı bulma.

            Random rnd = new Random();
            int[] sayilar = new int[20];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(1, 100);
            }
            Console.WriteLine(sayilar.Max());
            Console.WriteLine(sayilar.Min());
            #endregion



        }
    }
}
