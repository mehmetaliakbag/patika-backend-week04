# 02Constructor Projesi

Bu proje, `Baby` (Bebek) sınıfının temel özelliklerini ve kullanımını gösteren bir C# uygulamasıdır. Projede, bebek nesneleri oluşturulmakta ve bu nesnelerin bilgileri ekrana yazdırılmaktadır.

## Proje Yapısı

### `Baby` Sınıfı

- **Alanlar (Fields)**
  - `name`: Bebeğin adı.
  - `surname`: Bebeğin soyadı.
  - `dateOfBirth`: Bebeğin doğum tarihi.

- **Yapıcılar (Constructors)**
  1. **Parametreli Yapıcı**: Ad ve soyadı ile bebek nesnesi oluşturulmasını sağlar.
  2. **Parametresiz Yapıcı**: Hiçbir parametre verilmeden bebek nesnesi oluşturulmasını sağlar.

- **Özellikler (Properties)**
  - `Name`: Bebeğin adını almak ve ayarlamak için kullanılır.
  - `Surname`: Bebeğin soyadını almak ve ayarlamak için kullanılır.

- **Metodlar (Methods)**
  - `MakeASound()`: Bebeğin çıkardığı sesi konsola yazdırır.
  - `DisplayInfoAboutBaby()`: Bebeğin adı, soyadı ve doğum tarihini konsola yazdırır.

## Kullanım

Projenin ana kısmı, `Baby` sınıfını kullanarak iki bebek nesnesi oluşturmakta ve bu nesnelerin bilgilerini ekrana yazdırmaktadır.

### Örnek Kullanım

```csharp
using _02Constructor;

Baby baby1 = new Baby("Volkan", "Sütçüoğlu");
Console.WriteLine("İlk bebek oluşturuldu");
baby1.DisplayInfoAboutBaby();

Console.WriteLine("\r\n---------------\r\n");

Baby baby2 = new Baby();
Console.WriteLine("İkinci bebek oluşturuldu");
baby2.DisplayInfoAboutBaby();

Console.WriteLine("\r\n---------------\r\n");

Console.WriteLine("İkinci bebeğin ad ve soyadı bilgileri eklendi");
baby2.Name = "Aslı";
baby2.Surname = "Sütçüoğlu";

Console.WriteLine("\r\n---------------\r\n");

baby2.DisplayInfoAboutBaby();
```

### Çıktı

1. İlk bebek "Volkan Sütçüoğlu" adıyla oluşturulur ve bilgileri yazdırılır.
2. İkinci bebek, ad ve soyadı olmadan oluşturulur ve doğum tarihi yazdırılır.
3. İkinci bebeğin adı ve soyadı daha sonra eklenir ve bilgileri tekrar yazdırılır.

## Sonuç

Bu proje, C# dilinde nesne yönelimli programlamanın temellerini anlamak için iyi bir örnektir. `Baby` sınıfı üzerinden, yapıcılar, özellikler ve metodlar arasındaki ilişki gösterilmiştir.