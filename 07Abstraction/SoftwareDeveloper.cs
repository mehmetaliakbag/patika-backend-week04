using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Abstraction
{
    public sealed class SoftwareDeveloper : Employee
    {

        public SoftwareDeveloper(string firstname, string lastname)
            :base(firstname, lastname, "Sofware Department")
        {
        }


        public override void GetInfo()
        {
            Console.WriteLine("Yazılım geliştiricisi olarak çalışıyorum.");
        }
    }




}
