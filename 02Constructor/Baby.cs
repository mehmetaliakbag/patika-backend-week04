    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace _02Constructor
    {
        public class Baby
        {
            //Fields
            private string name;
            private string surname;
            private DateTime dateOfBirth;

            //1-Constructor
            public Baby(string name, string surname)
            {
                //Nesne oluşturulduğunda girilen parametreler nesnenin başlangıç değerleri olacak
                this.name = name;
                this.surname = surname;
                //Her nesne oluşturulduğunda nesnenin oluşma anı bebeğin doğum tarihi olacak
                dateOfBirth = DateTime.Now;
                //Her yeni nesne oluşturulduğunda bu metot çalışacak
                MakeASound();
            
            }

            //2-Constructor
            public Baby()
            {
                //Nesne tanıtılacak ama başlangıç değerleri olmayacak
                //Her nesne oluşturulduğunda nesnenin oluşma anı bebeğin doğum tarihi olacak
                dateOfBirth = DateTime.Now;
                //Her yeni nesne oluşturulduğunda bu metot çalışacak
                MakeASound();
            }

            //Properties
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            public string Surname
            {
                get
                {
                    return surname;
                }
                set
                {
                    surname = value;
                }
            }

            //Methods
            public void MakeASound()
            {
                Console.WriteLine("Ingaaa, ıngaaa, ıngaaa");
            }

            public void DisplayInfoAboutBaby()
            {
                Console.WriteLine($"Adı: {name}" +
                    $"\r\nSoyadı: {surname}" +
                    $"\r\nDoğum tarihi: {dateOfBirth}");
            }

        }
    }
