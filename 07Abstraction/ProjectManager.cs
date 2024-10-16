using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Abstraction
{
    public class ProjectManager : Employee
    {

        //Kurucu metotu override ediyorum
        //Departmen değeri o bölümde olan herkes için aynı olacağı için değeri kurucuya veriyorum
        public ProjectManager(string firstname, string lastname)
        :base(firstname, lastname, "Project Manager")
        { }

        //Ovveride
        public override void GetInfo()
        {
            Console.WriteLine("Proje yöneticisi olarak çalışıyorum");
        }

    }
}
