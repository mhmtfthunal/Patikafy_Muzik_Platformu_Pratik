# Patikafy Müzik Platformu - Pratik

Bu uygulama, 11 sanatçıya ait verilerden oluşan bir liste üzerinde **LINQ** sorguları kullanarak çeşitli filtreleme, sıralama ve seçim işlemleri yapar.

---

## 🎯 Amaç

* `List<T>` koleksiyonunda nesne listesi oluşturmak.
* LINQ ile filtreleme, sıralama ve seçim yapmak.
* Sanatçı verilerini farklı kriterlere göre listelemek.

---

## 🧠 Mantık Özeti

1. **Veri Modeli:**

   * `Sarkici` sınıfı: `Ad`, `CikisYili`, `MuzikTuru`, `AlbumSatisMilyon` property’leri.
2. **Veri Listesi:**

   * 11 sanatçı nesnesi `List<Sarkici>` içine eklenir.
3. **Sorgular:**

   1. **Adı 'S' ile başlayan şarkıcılar** → `StartsWith("S")`
   2. **Albüm satışları 10 milyon üstü** → `Where(s => s.AlbumSatisMilyon > 10)`
   3. **2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar**

      * Filtre: `CikisYili < 2000 && MuzikTuru.Contains("Pop")`
      * Sıralama: `OrderBy(CikisYili).ThenBy(Ad)`
   4. **En çok albüm satan şarkıcı** → `OrderByDescending(...).First()`
   5. **En yeni ve en eski çıkış yapan şarkıcılar**

      * En yeni: `OrderByDescending(CikisYili).First()`
      * En eski: `OrderBy(CikisYili).First()`

---

## 📁 Kullanılan LINQ Metotları

* `Where` → Filtreleme yapmak için.
* `StartsWith` → Belirli harfle başlayan metinleri bulmak için.
* `OrderBy`, `OrderByDescending` → Sıralama işlemleri.
* `ThenBy` → İkincil sıralama.
* `First` → İlk elemanı almak için.

---

## 🖨️ Örnek Çıktı

```
Adı 'S' ile başlayan şarkıcılar:
Sezen Aksu
Sertab Erener
Sıla
Şebnem Ferah

Albüm satışları 10 milyon üstü:
Sezen Aksu - 15M
Ajda Pekkan - 20M
Tarkan - 30M
Ebru Gündeş - 12M

2000 yılı öncesi çıkış yapmış pop müzik sanatçıları:
1968 - Ajda Pekkan
1975 - Sezen Aksu
1984 - MFÖ
1992 - Sertab Erener
1992 - Tarkan
1993 - Kenan Doğulu

En çok albüm satan: Tarkan - 30M
En yeni çıkış yapan: Sıla - 2007
En eski çıkış yapan: Zeki Müren - 1951
```

---

## 📌 Notlar

* Müzik türü karşılaştırmalarında `ToLower()` veya `Contains("pop")` kullanılarak büyük/küçük harf duyarlılığı kaldırılabilir.
* Liste verileri örnek olarak hazırlanmıştır; istenirse değiştirilebilir.

---
