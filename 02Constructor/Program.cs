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
