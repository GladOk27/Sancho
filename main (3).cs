using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Info
    {
    
        public string Name, Family, Middlename;
        public byte Age;
        public void writeInConsoleInfo(string name, string family, string Middlename, byte age)
        {
            Console.WriteLine("Имя: {0}\nФамилия: {1}\nОтчество: {2}\nВозраст: {3}\n", name, family, Middlename, age);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Info myInfo = new Info();

            myInfo.Name = "Лукашенко";
            myInfo.Family = "Николай";
            myInfo.Middlename = "Александрович";
            myInfo.Age = 16;

            myInfo.writeInConsoleInfo(myInfo.Name, myInfo.Family, myInfo.Middlename, myInfo.Age);

            Console.ReadLine();
        }
    }

}