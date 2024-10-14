using _03Library;

//new keyword ile Book sınıfının kurucu metotu çağırılır, nesne oluşturmak için
Book book1 = new Book("Monte Kristo Konto", "Alexander", "Dumas", 1200, "Türkiye İş Bankası Yayınları");
book1.DisplayInfo();

Console.WriteLine("\r\n------------\r\n");

//Nesne oluşturuldu ama başlangıç değeri yok, sadece kayıt tarihi belli
Book book2 = new Book();
book2.DisplayInfo();

Console.WriteLine("\r\n------------\r\n");

//Properties metotlarını çağırarak nesneye ilk değerini veriyorum
book2.BookTitle = "Yerdeniz";
book2.AuthorFirstName = "Ursula";
book2.AuthorLastName = "Kroeber Le Guin";
book2.PageCount = 1500;
book2.Publisher = "Metis Yayınları";
book2.DisplayInfo();
