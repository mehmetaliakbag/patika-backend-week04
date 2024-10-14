# Kütüphane - Kitap Kayıt Uygulaması

Bu proje, Patika Kütüphanesi için bir kitap kayıt uygulaması geliştirmek amacıyla oluşturulmuştur. Kullanıcılar, kitapların bilgilerini kayıt altına alabilmekte ve bu bilgileri görüntüleyebilmektedir.

## Proje İçeriği

#### 1. Kitap Sınıfı (Book Class)
Kitap nesnelerini temsil eden bir Book sınıfı oluşturulmuştur. Bu sınıf, aşağıdaki özellikleri barındırmaktadır:

- Kitap Adı (bookTitle)
- Yazar Adı (authorFirstName)
- Yazar Soyadı (authorLastName)
- Sayfa Sayısı (pageCount)
- Yayınevi (publisher)
- Kayıt Tarihi (registrationDate) (otomatik olarak oluşturulma anında atanır)

#### 2. Constructor'lar

###### Parametreli Constructor

Kullanıcının kitap bilgilerini girmesine olanak tanır ve kayıt tarihini otomatik olarak atar.

###### Default Constructor

Parametre almadan bir nesne oluşturulmasını sağlar ve kayıt tarihini otomatik olarak atar.

#### 3. Properties

Nesne içindeki alanlara doğrudan erişimi kapatıp, güvenli bir şekilde erişim sağlar. Kullanıcı, doğrudan değişkenler yerine bu özellikleri kullanarak nesneye değer atayabilir.

#### 4. Metotlar

###### DisplayInfo(): 

Kitap bilgilerini konsola yazdırmak için kullanılır.

### Kod Örneği

Aşağıdaki kod örneği, Book sınıfının nasıl kullanılacağını göstermektedir:


```csharp
using System;

namespace _03Library
{
    // Class Kitap nesnenin tümeli
    public class Book
    {
        // Fields
        private string bookTitle;
        private string authorFirstName;
        private string authorLastName;
        private int pageCount;
        private string publisher;
        private DateTime registrationDate;

        // Parametreli Constructor
        public Book(string bookTitle, string authorFirstName, string authorLastName, int pageCount, string publisher)
        {
            this.bookTitle = bookTitle;
            this.authorFirstName = authorFirstName;
            this.authorLastName = authorLastName;
            this.pageCount = pageCount;
            this.publisher = publisher;
            registrationDate = DateTime.Now;
        }

        // Default Constructor
        public Book()
        {
            registrationDate = DateTime.Now;
        }

        // Properties
        public string BookTitle { get { return bookTitle; } set { bookTitle = value; } }
        public string AuthorFirstName { get { return authorFirstName; } set { authorFirstName = value; } }
        public string AuthorLastName { get { return authorLastName; } set { authorLastName = value; } }
        public int PageCount { get { return pageCount; } set { pageCount = value; } }
        public string Publisher { get { return publisher; } set { publisher = value; } }
        public DateTime RegistrationDate { get { return registrationDate; } }

        // Kitap bilgilerini gösteren metot
        public void DisplayInfo()
        {
            Console.WriteLine($"Kitap Adı: {bookTitle}");
            Console.WriteLine($"Yazar: {AuthorFirstName} {AuthorLastName}");
            Console.WriteLine($"Sayfa Sayısı: {PageCount}");
            Console.WriteLine($"Yayınevi: {Publisher}");
            Console.WriteLine($"Kayıt Tarihi: {RegistrationDate}");
        }
    }
}
```

// Kullanım örnekleri



```csharp
Book book1 = new Book("Monte Kristo Konto", "Alexander", "Dumas", 1200, "Türkiye İş Bankası Yayınları");
book1.DisplayInfo();

Console.WriteLine("\r\n------------\r\n");

Book book2 = new Book();
book2.DisplayInfo();

Console.WriteLine("\r\n------------\r\n");

book2.BookTitle = "Yerdeniz";
book2.AuthorFirstName = "Ursula";
book2.AuthorLastName = "Kroeber Le Guin";
book2.PageCount = 1500;
book2.Publisher = "Metis Yayınları";
book2.DisplayInfo()

```
### Açıklamalar

###### Class

Book sınıfı, kitap nesnelerinin özelliklerini ve davranışlarını tanımlar.

###### Property

Kitap özelliklerine güvenli erişim sağlar. Dışarıdan doğrudan erişim yerine, bu özellikler üzerinden değer atanabilir.

###### New

new anahtar kelimesi, bir nesne oluşturmak için kullanılır. Constructor'lar çağrılarak yeni bir Book nesnesi yaratılır.

###### Constructor

Sınıfın nesneleri oluşturulurken başlangıç değerlerini ayarlamak için kullanılan özel metotlardır. Parametreli ve parametresiz olmak üzere iki türü vardır.
