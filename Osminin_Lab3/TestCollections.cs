using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osminin_Lab3
{
    internal class TestCollections
    {
        private List<Team> teams;
        private List<string> str;
        private Dictionary<Team, ResearchTeam> dic1;
        private Dictionary<string, ResearchTeam> dic2;

        public void Generator(int value)
        {
            for (int i = 1; i <= value; i++)
            {
                int a = i % 3;
                var t1 = new Team(i.ToString() + "company", i);
                teams.Add(t1);

                var t2 = i.ToString();
                str.Add(t2);

                var t4 = new ResearchTeam(i.ToString() + "topic", i.ToString() + "company", i, (TimeFrame)a);
                dic1.Add(t1, t4);
                dic2.Add(t2, t4);
            }


        }

        public TestCollections(int value)
        {
            teams = new List<Team>(value);
            str = new List<string>(value);
            dic1 = new Dictionary<Team, ResearchTeam>(value);
            dic2 = new Dictionary<string, ResearchTeam>(value);
        }

        public void TimeSearch()
        {
            int time1 = Environment.TickCount;
            teams.Contains(teams[0]);
            int time2 = Environment.TickCount;
            Console.WriteLine($"Время поиска первого элемента в List<Team>: {time2 - time1}; " + teams[0].ToString());

            int time3 = Environment.TickCount;
            teams.Contains(teams[teams.Count / 2 - 1]);
            int time4 = Environment.TickCount;
            Console.WriteLine($"Время поиска центрального элемента в List<Team>: {time4 - time3}; " + teams[teams.Count / 2 - 1].ToString());


            int time5 = Environment.TickCount;
            teams.Contains(teams[teams.Count - 1]);
            int time6 = Environment.TickCount;
            Console.WriteLine($"Время поиска последнего элемента в List<Team>: {time6 - time5}; " + teams[teams.Count - 1].ToString());


            int time7 = Environment.TickCount;
            teams.Contains(new Team());
            int time8 = Environment.TickCount;
            Console.WriteLine($"Время поиска элемента, которого нет в List<Team>: {time8 - time7}");


            Console.WriteLine();


            int time12 = Environment.TickCount;
            str.Contains(str[0]);
            int time22 = Environment.TickCount;
            Console.WriteLine($"Время поиска первого элемента в List<string>: {time22 - time12}; " + str[0].ToString());

            int time32 = Environment.TickCount;
            str.Contains(str[str.Count / 2 - 1]);
            int time42 = Environment.TickCount;
            Console.WriteLine($"Время поиска центрального элемента в List<string>: {time42 - time32}; " + str[str.Count / 2 - 1].ToString());


            int time52 = Environment.TickCount;
            str.Contains(str[str.Count - 1]);
            int time62 = Environment.TickCount;
            Console.WriteLine($"Время поиска последнего элемента в List<string>: {time62 - time52}; " + str[str.Count - 1].ToString());


            int time72 = Environment.TickCount;
            str.Contains("asd");
            int time82 = Environment.TickCount;
            Console.WriteLine($"Время поиска элемента, которого нет в List<string>: {time82 - time72}");



            Console.WriteLine();

            List<Team> list = dic1.Keys.ToList();


            int time13 = Environment.TickCount;
            dic1.ContainsKey(list[0]);
            int time23 = Environment.TickCount;
            Console.WriteLine($"Время поиска первого элемента ключа (Team) в словаре Dictionary<Team, ResearchTeam>: {time23 - time13}; " + list[0].ToString());




            int time33 = Environment.TickCount;
            dic1.ContainsKey(list[list.Count / 2 - 1]);
            int time43 = Environment.TickCount;
            Console.WriteLine($"Время поиска центрального элемента ключа (Team) в словаре Dictionary<Team, ResearchTeam>: {time43 - time33}; " + list[list.Count / 2 - 1].ToString());



            int time53 = Environment.TickCount;
            dic1.ContainsKey(list[list.Count - 1]);
            int time63 = Environment.TickCount;
            Console.WriteLine($"Время поиска последнего элемента ключа (Team) в словаре Dictionary<Team, ResearchTeam>: {time63 - time53}; " + list[list.Count - 1].ToString());




            int time73 = Environment.TickCount;
            dic1.ContainsKey(new Team());
            int time83 = Environment.TickCount;
            Console.WriteLine($"Время поиска элемента ключа (Team), которого нет в словаре Dictionary<Team, ResearchTeam>: {time83 - time73}");



            Console.WriteLine();


            List<ResearchTeam> list2 = dic1.Values.ToList();


            int time14 = Environment.TickCount;
            dic1.ContainsValue(list2[0]);
            int time24 = Environment.TickCount;
            Console.WriteLine($"Время поиска первого элемента значения (ResearchTeam) в словаре Dictionary<Team, ResearchTeam>: {time24 - time14}; " + list2[0].ToString());



            int time34 = Environment.TickCount;
            dic1.ContainsValue(list2[list2.Count / 2 - 1]);
            int time44 = Environment.TickCount;
            Console.WriteLine($"Время поиска центрального элемента значения (ResearchTeam) в словаре Dictionary<Team, ResearchTeam>: {time44 - time34}; " + list2[list2.Count / 2 - 1].ToString());



            int time54 = Environment.TickCount;
            dic1.ContainsValue(list2[list2.Count - 1]);
            int time64 = Environment.TickCount;
            Console.WriteLine($"Время поиска последнего элемента значения (ResearchTeam) в словаре Dictionary<Team, ResearchTeam>: {time64 - time54}; " + list2[list2.Count - 1].ToString());




            int time74 = Environment.TickCount;
            dic1.ContainsValue(new ResearchTeam());
            int time84 = Environment.TickCount;
            Console.WriteLine($"Время поиска элемента значения (ResearchTeam), которого нет в словаре Dictionary<Team, ResearchTeam>: {time84 - time74}");


            Console.WriteLine();

            List<string> list3 = dic2.Keys.ToList();


            int time15 = Environment.TickCount;
            dic2.ContainsKey(list3[0]);
            int time25 = Environment.TickCount;
            Console.WriteLine($"Время поиска первого элемента ключа (string) в словаре Dictionary<Team, ResearchTeam>: {time25 - time15}; " + list[0].ToString());




            int time35 = Environment.TickCount;
            dic2.ContainsKey(list3[list3.Count / 2 - 1]);
            int time45 = Environment.TickCount;
            Console.WriteLine($"Время поиска центрального элемента ключа (string) в словаре Dictionary<Team, ResearchTeam>: {time45 - time35}; " + list[list.Count / 2 - 1].ToString());



            int time55 = Environment.TickCount;
            dic2.ContainsKey(list3[list3.Count - 1]);
            int time65 = Environment.TickCount;
            Console.WriteLine($"Время поиска последнего элемента ключа (string) в словаре Dictionary<string, ResearchTeam>: {time65 - time55}; " + list[list.Count - 1].ToString());



            int time75 = Environment.TickCount;
            dic2.ContainsKey("asd");
            int time85 = Environment.TickCount;
            Console.WriteLine($"Время поиска элемента ключа (string), которого нет в словаре Dictionary<string, ResearchTeam>: {time85 - time75}");



            Console.WriteLine();


            List<ResearchTeam> list4 = dic2.Values.ToList();


            int time16 = Environment.TickCount;
            dic2.ContainsValue(list4[0]);
            int time26 = Environment.TickCount;
            Console.WriteLine($"Время поиска первого элемента значения (ResearchTeam) в словаре Dictionary<string, ResearchTeam>: {time26 - time16}; " + list4[0].ToString());



            int time36 = Environment.TickCount;
            dic2.ContainsValue(list4[list4.Count / 2 - 1]);
            int time46 = Environment.TickCount;
            Console.WriteLine($"Время поиска центрального элемента значения (ResearchTeam) в словаре Dictionary<string, ResearchTeam>: {time46 - time36}; " + list4[list4.Count / 2 - 1].ToString());



            int time56 = Environment.TickCount;
            dic2.ContainsValue(list4[list4.Count - 1]);
            int time66 = Environment.TickCount;
            Console.WriteLine($"Время поиска последнего элемента значения (ResearchTeam) в словаре Dictionary<string, ResearchTeam>: {time66 - time56}; " + list4[list4.Count - 1].ToString());




            int time76 = Environment.TickCount;
            dic2.ContainsValue(new ResearchTeam());
            int time86 = Environment.TickCount;
            Console.WriteLine($"Время поиска элемента значения (ResearchTeam), которого нет в словаре Dictionary<string, ResearchTeam>: {time86 - time76}");
        }


    }
}
