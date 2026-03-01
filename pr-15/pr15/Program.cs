using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr15
{
    internal class Program
    {
        class Car
        {
            public string Marka;
            public int Celind;
            public double Power;

            public void MarkCel()
            {
                Console.WriteLine(" Торговая Марка и число целиндров: " +
                                Marka + Celind);
            }

            public double Izm()
            {
                return Power + 10;
            }
        }
        class Lorry : Car
        {
            //характеризуемый грузоподъемностью кузова
            public int GryzPod;
            public int Met()
            {
                return GryzPod + 100;
            }
            public void Gryzz()
            {
                Console.WriteLine("Грузоподъемность кузова  грузовика: " + GryzPod);
            }

        }

        class Liquid
        {
            public string name;
            public double density;

            public void NamDen()
            {
                Console.WriteLine(" Поля названия жидкости и их плотность: " +
                                name + density);
            }
            public double IzmPlot ()
            {
                return density + 20;
            }
        }

        class Alcohol : Liquid
        {
            public double strength;

            public void Krepkost()
            {
                Console.WriteLine(" Крепкость алкоголя:  " + strength);
            }

            public double IzmKrepk()
            {
                return strength + 10;
            }

        }

        class Man
        {
            public string firstname;
            public string surname;
            public string floor;
            public int age;
            public double weight;

            public void Info()
            {
                Console.WriteLine("Имя" + firstname);
                //Console.WriteLine("Фамилия" + surname);
                //Console.WriteLine("Пол" + floor);
               //Console.WriteLine("Возраст" + age);
                //Console.WriteLine("Вес" + weight);
            }

            public int IzmAge()
            {
                return age + 1;
            }

            public double IzmWeight()
            {
                return weight + 5;
            }
        }

        class Student: Man
        {
            public int year;
            public string specialization;

            public void YearSpec()
            {
                Console.WriteLine("Год обучения и специализация:" + year + specialization);
            }

            public int IzmYear()
            {
                return year + 1;
            }
        }
        static void Main(string[] args)
        {
            //Создать базовый класс Саr (машина), характеризуемый торговой маркой (строка), числом цилиндров, мощностью.
            //Определить методы переназначения и изменения мощности. Создать производный класс Lorry (грузовик),
            //характеризуемый грузоподъемностью кузова. Определить функции переназначения марки и изменения грузоподъемности.

            Console.WriteLine( "Задание 1");
            Lorry T1 = new Lorry();
            Lorry T2 = new Lorry();

            T1.Marka = "bmw";
            T1.Celind = 10;
            T1.Power = 139;

            T2.Marka = "Gazel";
            T2.Celind = 4;
            T2.Power = 106;
            T2.GryzPod = 100;

            Console.WriteLine("Сведенья об объекте T1:");
            T1.MarkCel();
            T1.Gryzz();
            Console.WriteLine("Мощность равна :" + T1.Izm());

            Console.WriteLine();

            Console.WriteLine("Сведенья об объекте T2:");
            T2.MarkCel();
            T2.Gryzz();
            Console.WriteLine("Мощность равна :" + T2.Izm());
            Console.WriteLine("Грузоподъемность  равна :" + T2.Met());

            Console.WriteLine("Задание 2");
            //Создать класс Liquid (жидкость), имеющий поля названия и плотности.
            //Определить методы переназначения и изменения плотности.
            //Создать производный класс Alcohol (спирт), имеющий крепость.
            //Определить методы переназначения и изменения крепости.

            Alcohol T3 = new Alcohol();
            Alcohol T4 = new Alcohol();

            T3.name = "water";
            T3.density = 10;

            T4.name = "wine";
            T4.density = 30;
            T4.strength = 20;

            Console.WriteLine("Сведенья об объекте T3:");
            T3.NamDen();
            T3.Krepkost();
            Console.WriteLine("Плотность равна :" + T3.IzmPlot());

            Console.WriteLine();

            Console.WriteLine("Сведенья об объекте T4:");
            T3.NamDen();
            T3.Krepkost();
            Console.WriteLine("Плотность равна :" + T3.IzmPlot());
            Console.WriteLine("Крепкость равна :" + T4.IzmKrepk());

            Console.WriteLine("Задание 3");
            //Создать класс Man (человек), с полями: имя, фамилия, возраст, пол и вес.
            //Определить методы переназначения имени, изменения возраста и изменения веса.
            //Создать производный класс Student, имеющий поля года обучения и специальность обучения.
            //Определить методы переназначения и увеличения года обучения.

            Student T5 = new Student();
            Student T6 = new Student();

            T5.firstname = "Петя";
            T5.surname = "Иванов";
            T5.floor = "Мужской";
            T5.age = 17;
            T5.weight = 60;

            T6.firstname = "Вася";
            T6.surname = "Петров";
            T6.floor = "Мужской";
            T6.age = 19;
            T6.weight = 88;
            T6.year = 3;
            T6.specialization = "ввуц";


            Console.WriteLine("Сведенья об объекте T5:");
            T5.Info();
            T5.YearSpec();
            Console.WriteLine("Возраст равен :" + T5.IzmAge());
            Console.WriteLine("Вес равен :" + T5.IzmWeight());

            Console.WriteLine("Сведенья об объекте T6:");
            T6.Info();
            T6.YearSpec();
            Console.WriteLine("Возраст равен :" + T6.IzmAge());
            Console.WriteLine("Вес равен :" + T6.IzmWeight());
            Console.WriteLine("Год обучения :" + T6.IzmYear());

        }
    }
}
