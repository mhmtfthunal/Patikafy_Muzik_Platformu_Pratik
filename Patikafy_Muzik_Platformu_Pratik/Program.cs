using System;
using System.Collections.Generic;
using System.Linq;

class Sarkici
{
    public string Ad { get; set; }
    public int CikisYili { get; set; }
    public string MuzikTuru { get; set; }
    public double AlbumSatisMilyon { get; set; }
}

class Program
{
    static void Main()
    {
        // 11 sanatçı örneği
        List<Sarkici> sarkicilar = new List<Sarkici>
        {
            new Sarkici { Ad = "Sezen Aksu", CikisYili = 1975, MuzikTuru = "Pop", AlbumSatisMilyon = 15 },
            new Sarkici { Ad = "Sertab Erener", CikisYili = 1992, MuzikTuru = "Pop", AlbumSatisMilyon = 5 },
            new Sarkici { Ad = "Ajda Pekkan", CikisYili = 1968, MuzikTuru = "Pop", AlbumSatisMilyon = 20 },
            new Sarkici { Ad = "Tarkan", CikisYili = 1992, MuzikTuru = "Pop", AlbumSatisMilyon = 30 },
            new Sarkici { Ad = "Barış Manço", CikisYili = 1962, MuzikTuru = "Rock", AlbumSatisMilyon = 7 },
            new Sarkici { Ad = "Şebnem Ferah", CikisYili = 1994, MuzikTuru = "Rock", AlbumSatisMilyon = 3 },
            new Sarkici { Ad = "Sıla", CikisYili = 2007, MuzikTuru = "Pop", AlbumSatisMilyon = 2 },
            new Sarkici { Ad = "MFÖ", CikisYili = 1984, MuzikTuru = "Pop Rock", AlbumSatisMilyon = 8 },
            new Sarkici { Ad = "Ebru Gündeş", CikisYili = 1993, MuzikTuru = "Arabesk", AlbumSatisMilyon = 12 },
            new Sarkici { Ad = "Kenan Doğulu", CikisYili = 1993, MuzikTuru = "Pop", AlbumSatisMilyon = 6 },
            new Sarkici { Ad = "Zeki Müren", CikisYili = 1951, MuzikTuru = "Klasik", AlbumSatisMilyon = 10 }
        };

        // 1) Adı 'S' ile başlayan şarkıcılar
        var sBaslayanlar = sarkicilar.Where(s => s.Ad.StartsWith("S", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Adı 'S' ile başlayan şarkıcılar:");
        foreach (var s in sBaslayanlar) Console.WriteLine(s.Ad);

        // 2) Albüm satışları 10 milyon'un üzerinde olan şarkıcılar
        var onMilyonUstu = sarkicilar.Where(s => s.AlbumSatisMilyon > 10);
        Console.WriteLine("\nAlbüm satışları 10 milyon üstü:");
        foreach (var s in onMilyonUstu) Console.WriteLine($"{s.Ad} - {s.AlbumSatisMilyon}M");

        // 3) 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar, çıkış yılına göre gruplu ve alfabetik
        var eskiPop = sarkicilar
            .Where(s => s.CikisYili < 2000 && s.MuzikTuru.ToLower().Contains("pop"))
            .OrderBy(s => s.CikisYili)
            .ThenBy(s => s.Ad);
        Console.WriteLine("\n2000 yılı öncesi çıkış yapmış pop müzik sanatçıları:");
        foreach (var s in eskiPop) Console.WriteLine($"{s.CikisYili} - {s.Ad}");

        // 4) En çok albüm satan şarkıcı
        var enCokSatan = sarkicilar.OrderByDescending(s => s.AlbumSatisMilyon).First();
        Console.WriteLine($"\nEn çok albüm satan: {enCokSatan.Ad} - {enCokSatan.AlbumSatisMilyon}M");

        // 5) En yeni ve en eski çıkış yapan şarkıcılar
        var enYeni = sarkicilar.OrderByDescending(s => s.CikisYili).First();
        var enEski = sarkicilar.OrderBy(s => s.CikisYili).First();
        Console.WriteLine($"En yeni çıkış yapan: {enYeni.Ad} - {enYeni.CikisYili}");
        Console.WriteLine($"En eski çıkış yapan: {enEski.Ad} - {enEski.CikisYili}");
    }
}
