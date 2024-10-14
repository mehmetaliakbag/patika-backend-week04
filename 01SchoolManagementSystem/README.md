# School Management System

## Proje Genel Bakışı

Okullardaki öğretmen ve öğrenci yönetimini kolaylaştırmak için hazırlanmıştır

## Kurulum Talimatları

### Gereksinimler

- .Net Framework 5 ve üzeri
- Visual Studio 2019 ve üzeri

### Kurulum Talimatları

1 - Bu depoyu kullanın 

```bash
https://github.com/mehmetaliakbag/patika-backend-week04/tree/master/01SchoolManagementSystem
```

2 - Proje klasörüne gidin:

```bash
cd SchoolManagementSystem
```

3 - Projeyi açın ve Visual Studio'da çalıştırın.

## Kullanım Kılavuzu

### Kullanıcı Arayüzü

Projenin ana arayüzü, kullanıcıların öğrenci, öğretmen ve sınıf bilgilerini yönetmelerini sağlar. Kullanıcılar aşağıdaki işlemleri gerçekleştirebilir:

- Yeni öğrenci ekleme
- Öğrenci bilgilerini güncelleme
- Öğrenci bilgilerini görüntüleme
- Öğretmen bilgilerini yönetme

Örnek Kullanım

```csharp
Person student = new Person
{
    Name = "Ali",
    Surname = "Yılmaz",
    DateOfBirth = new DateTime(2005, 5, 20)
};

student.GetPersonDetails();
```
Örnek Konsol Ekranı 

```markdown
Adı: Ali
Soyadı: Yılmaz
Doğum Tarihi: 5/5/2005
```

## Konfigürasyon
Projede varsayılan ayarları değiştirmek için appsettings.json dosyasını düzenleyebilirsiniz.

## Katkı Kuralları

Katkıda bulunmak için aşağıdaki adımları izleyin:

- Bu depoyu çatallayın (fork).
- Yeni bir dal oluşturun (branch):

```bash
git checkout -b yeni-ozellik
```

- Değişikliklerinizi yapın ve kaydedin:

```bash
git commit -m "Yeni özellik eklendi"
```

 Dalınızı GitHub'a itirin:

```bash
git push origin yeni-ozellik
```

- Bir çekme isteği (pull request) oluşturun.

## Lisans

```markdown
Bu proje MIT Lisansı ile lisanslanmıştır.
```

## İletişim
Proje hakkında herhangi bir sorunuz varsa, adınız ile iletişime geçebilirsiniz.


### Açıklamalar
- **Proje Genel Bakışı:** Projeyi tanımlar.
- **Kurulum Talimatları:** Kullanıcıların projeyi nasıl kuracaklarını açıklar.
- **Kullanım Kılavuzu:** Projeyi nasıl kullanacaklarına dair örnekler sunar.
- **Konfigürasyon:** Varsayılan ayarları değiştirme yöntemlerini belirtir.
- **Katkı Kuralları:** Başkalarının projeye nasıl katkıda bulunabileceğini açıklar.
- **Lisans:** Projeye ait lisansı belirtir.
- **İletişim:** Kullanıcıların sorularını iletebileceği bir iletişim bilgisi sunar.
