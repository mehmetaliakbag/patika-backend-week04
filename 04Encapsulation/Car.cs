using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Encapsulation
{
    public class Car
    {
        
        private string brand;  // Arabanın markası
        private string model;  // Arabanın modeli
        private string color;  // Arabanın rengi
        private int numberOfDoors;  // Arabanın kapı sayısı

        // Constructor
        public Car(string name, string model, string color, int numberOfDoors)
        {
            this.brand = name;
            this.model = model;
            this.color = color;
            this.numberOfDoors = numberOfDoors;
        }

        //Properties
        public string Brand { get { return brand; } set { brand = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string Color { get { return color; } set { color = value; } }
        public int NumberOfDoors
        {
            get
            {
                return numberOfDoors;
            }
            set
            {
                if (numberOfDoors == 2 || numberOfDoors == 4) // Eğer kapı sayısı 2 veya 4 ise değeri fielda ata
                    numberOfDoors = value;
                else
                {
                    Console.WriteLine("Geçersiz kapı sayısı"); // Diğer durumlarda hata mesajı yaz 
                    numberOfDoors = -1;  // Kapı sayısı -1 gir
                }
            }
        }

            public void CarInfo()
        {
            Console.WriteLine($"Car info" +
                $"\r\nBrand: {brand}" +
                $"\r\nModel: {model}" +
                $"\r\nColor: {color}" +
                $"\r\nNumber Of Door: {numberOfDoors}");
        }





        }
    }
