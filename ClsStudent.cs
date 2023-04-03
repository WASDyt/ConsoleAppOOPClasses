using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleAppOOPClasses
{
    internal class ClsStudent
    {
        private string fio;
        private DateTime birthday;
        private string adress;
        private string phone;
        private byte kurs;
        private string group;
        private double scholarship;
        public string FIO
        {
            get { return fio; }
            set { fio = value; }
        }
        public byte Kurs
        {
            get { return kurs; }
            set { kurs = value; }

        }
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
            }
        }
        public string Group
        {
            get { return group; }
            set { group = value; }
        }
        public  double Solarship
        {
            get { return scholarship; }
            set
            {
                scholarship = value;
            }
        }
        public ClsStudent()
        {
            kurs = 2;
            group = "ИСП21.1A";
            phone = "+70000000";
            fio = "Сергей Баталов";
            adress = "Давыдово";
            birthday = new DateTime(2005, 08, 24);
            scholarship = 0;
        }
        public ClsStudent(string f ,DateTime d, string ad,  byte k, string g, double s)
        {
            FIO = f;
            birthday = d;
                adress = ad;
            kurs = k;
            group= g;
            scholarship = s;
        }
        public void PrintToScreen()
        {
            Console.WriteLine($"Студент {fio} дата рождения {birthday} , к сожелению степуха {scholarship} тенге");
            Console.WriteLine($"учится {kurs} в группе {group}");
            Console.WriteLine($"Студент проживает по адрессу {adress}, телефон {phone}");

        }
        public void SaveToFile(string filename) 
        {
            StreamWriter streamWriter = new StreamWriter(filename,true, Encoding.Default); // создать прилож с испл класса
            streamWriter.WriteLine("Личные данные студента");
            streamWriter.WriteLine($"ФИО: {fio}");
            streamWriter.WriteLine($"Адрес проживания: {adress}");
            streamWriter.WriteLine($"Телефон: {phone}");
            streamWriter.WriteLine($"Курс: {kurs}");
            streamWriter.WriteLine($"Группа {group}");
        }
        public void GetFromKeyboard()
        {
            Console.WriteLine("Укажите ФИО студента");
            fio = Console.ReadLine();
            Console.WriteLine("Укажите адрес студента");
            adress = Console.ReadLine();
            Console.WriteLine("Укажите телефон студента");
            phone = Console.ReadLine();
            Console.WriteLine("Укажите дату рождения студента");
            Console.WriteLine("Год?"); int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Месяц?"); int month = int.Parse(Console.ReadLine());
            Console.WriteLine("День?"); int day = int.Parse(Console.ReadLine());
            birthday = new DateTime(year, month, day);
            Console.WriteLine("Укажите курс студента");
            kurs = byte.Parse(Console.ReadLine());
            Console.WriteLine("Укажите группу студента");
            group = Console.ReadLine();
        }
    }
}