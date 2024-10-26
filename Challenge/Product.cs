using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public class Product
    {

        public void ProduceDevice()
        {
            bool isContinue = false;

            while (!isContinue)
            {
            beginning:
                Console.WriteLine("Press 1 to produce a phone or 2 to produce a computer:");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Phone phone = new Phone();
                        phone.ModifyPhone();
                        phone.PrintInfo();
                        break;
                    case "2":
                        Computer computer = new Computer();
                        computer.ModifyComputer();
                        computer.PrintInfo();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please press 1 for phone or 2 for computer.");
                        goto beginning;
                }

                bool isValidAnswer = false;

                while (!isValidAnswer)
                {
                    Console.Write("Product has been successfully created" +
                      "\r\nDo you want to create another product? (yes/no): ");

                    string answer = Console.ReadLine();

                    if (answer.ToLower() == "yes")
                    {
                        isValidAnswer = true;
                    }
                    else if (answer.ToLower() == "no")
                    {
                        isContinue = true;
                        isValidAnswer = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }


            }



        }

    }
}
