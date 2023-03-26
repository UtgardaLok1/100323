using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MRT
{
    public class Physician
    {
        public Physician (string name, string surname, int age, string speciality, int experience, string shift)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Speciality = speciality;
            Experience = experience;
            Shift = shift;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Speciality { get; set; }
        public int Experience { get; set; }
        public string Shift { get; set; }

        public void Survey(Patient patient)
        {
            Random random = new Random();
            int chance = random.Next(1, 101);
            if (chance > 5 )
            {
                Console.WriteLine("Пациенту {0} {1} было составлено правильное заключение", patient.Name, patient.Surname);
                patient.Conclusion = "Заключение верное";
            }
            if (chance < 6 & Experience < 5)
            {
                Console.WriteLine("Пациенту {0} {1} было составлено неверное заключение", patient.Name, patient.Surname);
                patient.Conclusion = "Заключение неверное или некорректно составлено";
            }

        }

        public void PhysicianInfo(Physician physician)
        {
            Console.WriteLine("//////////////////////////////");
            Console.WriteLine($"Имя: {physician.Name}");
            Console.WriteLine($"Фамилия: {physician.Surname}");
            Console.WriteLine($"Возраст: {physician.Age}");
            Console.WriteLine($"Специальность: {physician.Speciality}");
            Console.WriteLine($"Стаж: {physician.Experience}");
            Console.WriteLine($"Предпочтительная смена: {physician.Shift}");
            Console.WriteLine("//////////////////////////////");
        }
    }

    public class Patient
    {
        public Patient (string name, string surname, int age, string insurancePolicy, string date, string research, string address, string phoneNumber, string conclusion)
        {
            Name = name;
            Surname = surname;
            Age = age;
            InsurancePolicy = insurancePolicy;
            Date = date;
            Research = research;
            Address = address;
            PhoneNumber = phoneNumber;
            Conclusion = conclusion;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string InsurancePolicy { get; set; }
        public string Date { get; set; }
        public string Research { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Conclusion { get; set; }

        public void PatientInfo(Patient patient)
        {
            Console.WriteLine("//////////////////////////////");
            Console.WriteLine($"Имя: {patient.Name}");
            Console.WriteLine($"Фамилия: {patient.Surname}");
            Console.WriteLine($"Возраст: {patient.Age}");
            Console.WriteLine($"Страховой полис: {patient.InsurancePolicy}");
            Console.WriteLine($"Дата: {patient.Date}");
            Console.WriteLine($"Заболевание: {patient.Research}");
            Console.WriteLine($"Адрес: {patient.Address}");
            Console.WriteLine($"Телефон: {patient.PhoneNumber}");
            Console.WriteLine($"Заключение: {patient.Conclusion}");
            Console.WriteLine("//////////////////////////////");
        }
    }

    public class Programm
    {
        static void Main(string[] args)
        {
            List<Physician> physicians = new List<Physician>()
            {
                new Physician (" Пётр", "Белодубов", 33, "Врач КТ", 5, "Утренняя"),
                new Physician (" Олеся", "Дождева", 27, "Врач МРТ", 1, "Вечерняя"),
                new Physician (" Тамара", "Заряева", 53, "Врач МРТ", 24, "Вечерняя"),
                new Physician (" Фёдор", "Карпов", 45, "Врач МРТ", 15, "Вечерняя"),
                new Physician (" Анастасия", "Листопадова", 31, "Врач КТ", 3, "Вечерняя"),
                new Physician (" Лидия", "Волкова", 37, "Врач МРТ", 11, "Утренняя"),
                new Physician (" Антон", "Пирогов", 26, "Врач МРТ", 0, "Утренняя"),
                new Physician (" Валерия", "Острова", 55, "Врач КТ", 27, "Утренняя"),
            };




            List<Patient> patients = new List<Patient>()
            {
                new Patient ("Николай", "Добряков", 23, "ОМС", "23.08.22", "Коленный сустав", "Ул. Пушкина, д. 35", "+7 996 261 52 84", "Патология выявлена"),
                new Patient ("Елизавета", "Тетерина", 27, "ОМС", "13.03.22", "Поясничный отдел позвоночника", "Ул. Колотушкина, д. 16", "+7 987 134 16 92", "Патология выявлена"),
                new Patient ("Элеонора", "Смирнова", 45, "ОМС", "15.03.22", "Голеностоп", "Ул. Есенина, д. 4", "+7 913 587 25 58", "Патология выявлена"),
                new Patient ("Николай", "Добряков", 49, "ОМС", "03.04.22", "Малый таз", "Ул. Каруселина, д. 8", "+7 922 837 28 35", "Патология выявлена"),
                new Patient ("Евдокия", "Маслова", 65, "ОМС", "09.07.22", "Тазобедренный сустав", "Ул. Романовского, д. 17", "+7 913 958 35 82", "Патология выявлена"),
                new Patient ("Карина", "Лебедева", 37, "ОМС", "16.02.22", "Шейный отдел позвоночника", "Ул. Фрунзе, д. 62", "+7 965 136 15 37", "Патология выявлена"),
                new Patient ("Аркадий", "Журавлев", 41, "ОМС", "26.12.22", "Локтевой сустав", "Ул. Павлова, д. 11", "+7 936 327 27 24", "Патология выявлена"),
                new Patient ("Марьяна", "Дьячкова", 37, "ОМС", "06.04.22", "Поясничный отдел позвоночника", "Ул. Достоевского, д. 14", "+7 996 784 16 16", "Патология выявлена"),
                new Patient ("Инесса", "Данилова", 53, "ОМС", "25.11.22", "Малый таз", "Ул. Чехова, д. 27", "+7 976 413 14 58", "Патология выявлена"),
            };


            while (true) 
            {
                int hour = DateTime.Now.Hour;
                if (hour >= 3 && hour <= 11)
                {
                    Console.WriteLine("Доброе утро!");
                }
                else if (hour >= 12 && hour <= 17)
                {
                    Console.WriteLine("Добрый день!");
                }
                else
                {
                    Console.WriteLine("Добрый вечер!");
                }
                Console.WriteLine(" ");
                Console.WriteLine("Что от меня требуется?");
                Console.WriteLine("1. Краткая информация о пациентах");
                Console.WriteLine("2. Какие исследования были проведены");
                Console.WriteLine("3. Количество исследований");
                Console.WriteLine("4. Количество врачей, работающих в центре");
                Console.WriteLine("5. Ничего?");

                int choice = 0;
                try 
                {
                    choice = UInt16.Parse(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("Эй! Пожалуйста, используйте целое число!");
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Краткое инфо: ");
                        foreach (Patient patient in patients)
                        {
                            patient.PatientInfo(patient);
                            Console.WriteLine("_______________________________________________________________________");
                            Console.WriteLine();

                        }
                        break;
                    case 2:
                        Console.WriteLine($"Вот полный список: ");
                        Random random = new Random();
                        foreach (Patient patient in patients) 
                            {
                                Console.WriteLine("Пациент {0} {1} был направлен на исследование {2}", patient.Name, patient.Surname, patient.Research);
                                var physician = physicians[random.Next(0, physicians.Count - 1)];
                                physician.Survey(patient);
                                Console.WriteLine("/////////////////////////////////////////");
                                Console.WriteLine();
                            }
                        break;
                    case 3:
                        Console.WriteLine($"Всего за год было проведено {patients.Count} исследований");
                        break;
                    case 4:                        
                        Console.WriteLine($"У нас работают {physicians.Count} врачей");                     
                        break;
                    case 5:
                        Console.WriteLine("До связи");
                        return;
                    default:
                        Console.WriteLine("Некорректный ввод.");
                        break;
                }
            }


        }
    }
}
        







