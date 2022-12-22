using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osminin_Lab3
{
    internal class ResearchTeamColletion
    {
        private List<ResearchTeam> resTeam = new List<ResearchTeam>();


        public void AddDefaults()
        {
            resTeam.Add(new ResearchTeam());
        }

        public void AddResearchTeams(params ResearchTeam[] arr)
        {
            resTeam.AddRange(arr);
        }

        public override string ToString()
        {
            string str = null;

            foreach (var team in resTeam)
            {
                str += team.ToString();
            }
            return str;
        }

        public virtual string ToShortString()
        {
            string str = null;
            int countMemb = 0;
            int countPapers = 0;
            foreach (var item in resTeam)
            {
                countMemb = item.ListMemb.Count;
                countPapers = item.ListPap.Count;
                str += item.ToShortString() + " Число участников: " + countMemb + " Число публикаций: " + countPapers + "\n";
            }
            return str;
        }

        public void SortRegNum()
        {
            resTeam.Sort();
        }

        public void SortResTopic()
        {
            resTeam.Sort(new ResearchTeam());
        }

        public void SortPaperNumber()
        {
            resTeam.Sort(new ResearchTeam.ResearchTeamComparer());
        }

        public int MinRegNum
        {
            get
            {
                if (resTeam == null)
                {
                    return 0;
                }
                else
                {
                    List<int> nums = new List<int>();
                    foreach (var item in resTeam)
                    {
                        nums.Add(item.RegNum);
                    }
                    return nums.Min();
                }
            }
        }

        public IEnumerable<ResearchTeam> FrameTwoYears
        {
            get
            {
                var list = from item in resTeam where item.Duration == TimeFrame.TwoYears select item;

                foreach (var item in list)
                {
                    yield return item;

                }
            }
        }


        public List<ResearchTeam> NGroup(int value)
        {
            List<ResearchTeam> list = new List<ResearchTeam>();
            foreach (var item in resTeam.GroupBy(x => x.ListMemb.Count == value))
            {
                if (item.Key == true)
                {
                    list.AddRange(item.ToList());
                }
            }
            return list;


        }




    }
}
