using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Adam_Asmaca_Proje_ödevi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            // Tahmin edilecek kelimelerin bulunduğu bir dizi oluşturuluyor
            string[] kelimeler = { "fırat", "universite", "yazılım", "mühendis" };

            // secilenKelime adlı değişken seçilen kelimeyi tutacak
            string secilenKelime;

            // Oyuncunun başlangıçtaki hak sayısı 5
            int hak = 6;

            // Rastgele kelime seçimi için Random sınıfı kullanılıyor
            Random rnd = new Random();

            // Rastgele bir kelime seçiliyor
            // rnd.Next(0, kelimeler.Length) ile kelimeler dizisinden bir kelime rastgele seçiliyor
            secilenKelime = kelimeler[rnd.Next(0, kelimeler.Length)];

            // Seçilen kelimenin harfleri yerine başlangıçta '-' koymak için bir char dizisi oluşturuluyor
            char[] yertutucu = new char[secilenKelime.Length];

            // Seçilen kelimenin uzunluğu kadar '-' karakterleri ekrana yazdırılıyor
            for (int i = 0; i < yertutucu.Length; i++)
            {
                yertutucu[i] = '*'; // Her karakteri '-' ile doldur
                Console.Write('*');  // Ekrana '-' yazdır
            }
            Console.WriteLine(); // Bir satır boşluk bırak

            // Oyunun ana döngüsü
            while (true)
            {
                // Kalan hak bilgisini ekrana yazdır
                Console.WriteLine("Kalan Hak:{0}", hak);

                // Oyuncudan bir harf girmesini iste
                Console.Write("Bir harf girin   :");

                // Kullanıcının girdiği harfi al ve char türüne çevir
                char harf = Convert.ToChar(Console.ReadLine());

                // Girilen harfin seçilen kelimede olup olmadığını kontrol etmek için bayrak
                bool bayrak = false;

                // Kaç tane doğru tahmin edilmeyen harf kaldığını saymak için değişken
                int kalanKelime = 0;

                // Seçilen kelimenin her bir harfi kontrol ediliyor
                for (int i = 0; i < secilenKelime.Length; i++)
                {
                    // Eğer tahmin edilen harf doğruysa yer tutucuya ekle
                    if (secilenKelime[i] == harf)
                    {
                        yertutucu[i] = harf; // Doğru tahmin edilen harf yer tutucuda gösteriliyor
                        bayrak = true;       // Doğru tahmin yapıldığını gösteren bayrak
                    }

                    // Eğer yer tutucuda hâlâ '-' varsa kelime tamamlanmamış demektir
                    if (yertutucu[i] == '*')
                    {
                        kalanKelime++; // Kalan harfleri say
                    }

                    // Güncel yer tutucu durumu ekrana yazdırılıyor
                    Console.Write(yertutucu[i]);
                }
                Console.WriteLine(); // Satır sonu

                // Eğer tahmin edilmemiş harf kalmadıysa oyunu kazan
                if (kalanKelime == 0)
                {
                    Console.WriteLine("İyi Oyundu***"); // Tebrik mesajı
                    break; // Döngüyü bitir, oyun sona erdi
                }

                // Eğer bayrak false ise, yani doğru tahmin yapılamadıysa, hak bir azaltılıyor
                if (bayrak == false)
                {
                    hak--; // Bir yanlış tahmin sonrası hak düşüyor
                }

                // Eğer hak sıfıra düşerse oyunu kaybet
                if (hak == 0)
                {
                    Console.WriteLine("Malesef Kaybettiniz"); // Kaybetme mesajı
                    break; // Döngüyü bitir, oyun sona erdi
                }

                // Her tur sonunda oyunun durumu ekrana yazdırılıyor
                Console.WriteLine("------------------------");
            }

            // Oyun bitiminde seçilen kelime ekrana yazdırılıyor
            Console.Write("Seçtiğim kelime << {0} >>", secilenKelime);

            // Konsolu açık tutmak için bir satır boşluk bırakılıyor
            Console.ReadLine();
            #endregion
        }
    }
}
