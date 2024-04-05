using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ürünkodlarıezberleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> urunVeSerileri = new Dictionary<string, string>
        {
            { "ayçekirdeği tuzsuz", "2044" },{ "fıstık antep", "2012" }, { "koktey natural", "2082" },{ "erik sarı ", "4071" }, { "bulgur midyat", "1033" }, { "pirinç kırık", "1013" },{ "kimyon", "8101" }, { "jellybig", "8225" },{ "pudra şekeri", "1311" },
            { "ayçekirdeği tuzlu", "2043" },{ "fıstık kendy", "2054" }, { "koktey özel", "2152" },{ "hurma bağdat", "4049" }, { "bulgur pilavlık", "1032" },{ "pirinç osmancık", "1012" }, { "köri", "8031" },{ "top sakız", "7121" },{ "toz şeker", "1113" },
            { "Badem Ciğ", "2061" },{ "fıstık siirt", "2011" }, { "bulgur köftelik", "1031" },{ "koktey eko eneji", "2084" }, { "hurma medjoul", "4042" },{ "pirinç yerli", "1015" }, { "limon tuzu tane", "8012" },{ "jöle küp", "1127" },{ "un", "1141" },
            { "Badem Kavrulmus", "2063" },{ "fıstık soslu", "2056" }, { "koktey gurme", "2153" },{ "incir natural", "4031" }, { "bulgur seferkitel", "1037" },{ "pirinç basmati", "1016" }, { "limon tuzu toz", "8011" },{ "jelly berry", "8224" },
            { "Ceviz ici Lüks", "2102" }, { "fıstık tango ", "2059" },{ "koktey lüks", "2151" }, { "incir kıyılmış", "4030" },{ "bulgur şehriyeli", "1036" }, { "ev mantısı", "1211" },{ "nane", "8061" },{ "jellyrop", "1125" },
            { "Ceviz ici Ozel", "2103" }, { "fıstık toppy", "2055" },{ "koktey lüks eneji", "2085" }, { "gün kurusu", "4021" },{ "fasulye dermason", "1045" }, { "biber acı toz", "8153" },{ "sumak tane", "8022" },{ "lokum çeşitleri", "3100" },
            { "Ceviz Kabuklu", "2101" }, { "fıstık tuzlu lüks ", "2053" },{ "leblebi beyaz duble", "2094" }, { "sarı kayısı", "4022" },{ "fasulye horoz", "1046" }, { "biber ipek", "8151" },{ "sumak toz", "8021" },{ "lokum çikolatalı", "3128" },
            { "Cips Ballı Susamlı", "2132" }, { "fıstık tuzsuz lüks", "2052" },{ "leblebi sarı duble", "2092" }, { "kayısı kıyılmış", "4025" },{ "mercimek kırmızı", "1021" }, { "biber isot", "8155" },{ "susam", "8081" },{ "lokum fıstık sütlü", "3120" },
            { "Cips Fıstık", "2057" }, { "kabak nevşehir", "2032" },{ "leblebi şeker beyaz", "2097" }, { "kuş üzümü", "4011" },{ "mercimek sarı", "1023" }, { "biber tatlı toz", "8154" },{ "tarcıntoz", "8121" },{ "kahve", "6031" },
            { "Cips Sapkalı", "2131" }, { "kabak çifte nevşehir", "2031" },{ "leblebi şeker renkli", "2096" }, { "üzüm besni", "4012" },{ "mercimek yeşil", "1022" }, { "biber yağlı ", "8152" },{ "yeni bahar", "8111" },{ "yulaf ezmesi", "5111" },
            { "Cips Tırtıl", "2133" }, { "kabak içi çiğ", "2035" },{ "mısır soslu", "2111" }, { "üzüm izmir", "4014" },{ "mısır popcorn", "1111" }, { "çörekotu", "8091" },{ "zencefil", "8211" },{ "galete unu", "1134" },
            { "Fındık ici Ciğ", "2022" }, { "kabak edirne", "2033" },{ "karpuz çekirdeği", "2121" }, { "üzüm siyah çekirdeksiz", "4013" },{ "karabiber toz", "8041" }, { "zerdecal", "8221" },{ "hindistan çevizi", "1371" },
            { "fındık kabuklu", "2023" }, { "kabak tuzsuz", "2034" },{ "cıtır fıstık", "8222" }, { "buğday aşurelik", "1061" },{ "nohut sarı", "1052" }, { "karabiber tane", "8042" },{ "jelibon yumuşak", "1121" },{ "irmik", "1313" },
            { "fındık kabuklu tuzlu", "2024" }, { "kaju çiğ", "2071" },{ "fıstık kabuklu", "2051" }, { "bulgur başbaşı", "1038" },{ "nohut büyük", "1051" }, { "karbonat", "8131" },{ "jellycik", "1122" },{ "mısır nişantası", "1312" },
            { "fındık kavrulmuş", "2021" }, { "kaju kavrulmuş", "2072" },{ "dut kurusu", "4051" }, { "bulgur esmer köftelik", "1035" },{ "pirinç baldo", "1011" }, { "kekik", "8051" },{ "jöle şeker", "1123" },{ "mısır unu", "1135" },


        };

            List<string> urunler = new List<string>(urunVeSerileri.Keys);

            Console.WriteLine("Ürünleri Ezberleme Programı");
            Console.WriteLine("**************************");

            Random rastgele = new Random();

            while (urunler.Count > 0)
            {
                int rastgeleIndex = rastgele.Next(urunler.Count);
                string rastgeleUrun = urunler[rastgeleIndex];

                Console.WriteLine("Ezberlemen gereken ürün: " + rastgeleUrun);
                Console.Write("Seri numarasını girin: ");
                string girilenSeriNo = Console.ReadLine();

                if (girilenSeriNo == urunVeSerileri[rastgeleUrun])
                {
                    Console.WriteLine("Tebrikler! Doğru seri numarasını girdiniz.");
                    Console.WriteLine(urunVeSerileri[rastgeleUrun]);
                    urunler.RemoveAt(rastgeleIndex);
                }
                else
                {
                    Console.WriteLine("Maalesef yanlış seri numarası. Tekrar deneyin.");
                    Console.WriteLine(urunVeSerileri[rastgeleUrun]);
                }


            }

            Console.WriteLine("Tüm ürünleri doğru bir şekilde ezberlediniz!");
            Console.ReadLine();

        }
    }
}
