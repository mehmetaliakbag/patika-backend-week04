using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Library
{

    //Class Kitap nesnenin tümeli
    public class Book
    {
        //Fields Nesne oluşturulduğunda sahip olacağı primitive veya complex değerler
        private string bookTitle;
        private string authorFirstName;
        private string authorLastName;
        private int pageCount;
        private string publisher;
        private DateTime registrationDate;

        //1 Constructor Nesnenin oluşturulması için çağırılan kurucu metot
        public Book(string bookTitle, string authorFirstName, string authorLastName, int pageCount, string publisher)
        {
            this.bookTitle = bookTitle;
            this.authorFirstName = authorFirstName;
            this.authorLastName = authorLastName;
            this.pageCount = pageCount;
            this.publisher = publisher;
            //Kayıt tarihi nesne oluşturulduğu an olacak
            registrationDate = DateTime.Now;
        }

        //2 Constructor Nesnenin oluşturulması için çağırılan parametre almayan kurucu metot
        public Book()
        {
            //Kayıt tarihi nesne oluşturulduğu an olacak
            registrationDate = DateTime.Now;
        }

        //Properties Nesnenin değerlerine doğrudan ulaşımı kapatan enkapsüllemeye yapan metotlar
        //Kullanıcı doğrudan nesnenin değişkenleri değil nesneye ait metotları çağırır
        public string BookTitle { get { return bookTitle; } set { bookTitle = value; } }
        public string AuthorFirstName { get { return authorFirstName; } set { authorFirstName = value; } }
        public string AuthorLastName { get { return authorLastName; } set {authorLastName = value; } }
        public int PageCount { get { return pageCount; } set { pageCount = value; } }
        public string Publisher { get { return publisher; } set { publisher = value; } }
        public DateTime RegistrationDate { get { return registrationDate; } }

        // Method to display book information
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
