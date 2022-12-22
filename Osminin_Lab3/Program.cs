using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osminin_Lab3
{
    public enum TimeFrame
    {
        Year,
        TwoYears,
        Long
    }

    internal class Program
    {
        public static void Main(string[] args)
        {

            Person theRock = new Person("Dwayne", "Johnson", new DateTime(1972, 05, 02));
            Person misha = new Person("Michael", "Mironov", new DateTime(2003, 05, 19));
            Person alex = new Person("Alex", "Osminin", new DateTime(2003, 11, 26));
            Person rya = new Person();
            Person alex2 = new Person("Alex2", "Osminin2", new DateTime(2003, 11, 26));
            Person p1 = new Person("P1", "p1", new DateTime(2003, 10, 15));
            Person p2 = new Person("P2", "p2", new DateTime(2003, 10, 15));
            Person p3 = new Person("P3", "p3", new DateTime(2003, 10, 15));
            Person person = new Person(null, null, new DateTime());
            Person lesha = new Person("Lesha", "Osminin", new DateTime(2006, 09, 24));

            Paper paper = new Paper("Python", alex, new DateTime(1990, 10, 07));
            Paper pap = new Paper("JS", alex, new DateTime(1990, 10, 07));
            Paper paper1 = new Paper("Java", misha, new DateTime(2020, 11, 5));
            Paper paper3 = new Paper("C#", rya, new DateTime(2021, 6, 12));
            Paper paper4 = new Paper("C++", theRock, new DateTime(2022, 4, 20));
            Paper paper5 = new Paper("Kotlin", theRock, new DateTime(2021, 12, 20));


            ResearchTeam research1 = new ResearchTeam("Programming Languages", "VK", 1123, TimeFrame.Year);
            ResearchTeam research2 = new ResearchTeam("English lessons", "RTU MIREA", 12, TimeFrame.TwoYears);
            ResearchTeam research3 = new ResearchTeam("Анализ", "ABC", 13, TimeFrame.TwoYears);
            ResearchTeam research4 = new ResearchTeam("ООП", "RTU MIREA", 13, TimeFrame.TwoYears);


            Team t1 = new Team("RTU MIREA", 11);
            Team t2 = new Team("RTU MIREA", 11);
            Team t3 = new Team("RTU MIREA", 1241);



            Console.WriteLine("Задание 1");


            ResearchTeamColletion rColl = new ResearchTeamColletion();

            rColl.AddDefaults();

            research1.AddMembers(alex, misha);
            research1.AddPapers(paper, paper1, paper4);

            research3.AddMembers(rya);
            research3.AddPapers(paper4);

            rColl.AddResearchTeams(research1, research3, research2, research4);

            Console.WriteLine(rColl.ToString());
            Console.WriteLine(rColl.ToShortString() + "\n");

            Console.WriteLine("Задание 2");

            Console.WriteLine("Сортировка по регистрационному номеру: ");

            rColl.SortRegNum();

            Console.WriteLine(rColl.ToString() + "\n");


            rColl.SortResTopic();

            Console.WriteLine("Сортировка по названию исследования: ");

            Console.WriteLine(rColl.ToShortString() + "\n");

            rColl.SortPaperNumber();

            Console.WriteLine("Сортировка по колличеству публикаций: ");
            Console.WriteLine(rColl.ToShortString() + "\n");


            Console.WriteLine("Задание 3");
            Console.WriteLine($"Минимальное значение регистрационного номера: {rColl.MinRegNum}");

            var list = rColl.FrameTwoYears;

            Console.WriteLine("\n" + "Фильтрация проектов с продолжительностью TwoYears: ");

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }



            Console.WriteLine("\n" + "Группировка элементов списка по числу членов организации: ");


            var list2 = rColl.NGroup(2);

            foreach (var item in list2)
            {
                Console.WriteLine(item.ToString());
            }


            Console.WriteLine();


            Console.WriteLine("Задание 4");

            Console.WriteLine("Введите колличество элементов в коллекциях: ");

            bool chek = false;
            int input1 = 0;

            while (!chek)
            {
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    chek = true;
                    if (input <= 0)
                    {
                        chek = false;
                        Console.WriteLine("Вводимые данные должны быть целочисленным положительным числом.");
                    }
                    input1 = input;
                }
                catch (Exception)
                {
                    Console.WriteLine("Вводимые данные должны быть целочисленным положительным числом.");
                    chek = false;
                }
            }

            TestCollections test = new TestCollections(input1);

            test.Generator(input1);

            Console.WriteLine();

            test.TimeSearch();




            Console.ReadKey();
        }
    }
}
