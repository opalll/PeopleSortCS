using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testcs
{
    class PeopleSort
    {
        public string name;
        public int age;
        public int number;
        private static PeopleSort[] box = new PeopleSort[10000];
        private string status;
        public static int count;
        public PeopleSort(string name, int age)
        {
            this.name = name;
            this.age = age;
            Status = status;
            count++;
            this.number = count;
        }
        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                if (age >= 0 && age < 18)
                {
                    status = "young";
                }
                else if (age >= 18 && age < 64)
                {
                    status = "adult";
                }
                else if (age >= 64)
                {
                    status = "old";
                }
                else
                {
                    status = "error";
                }
            }
        }
        public static void CheckIn(PeopleSort ppl)
        {
            box[count] = ppl;
        }
        public static void ShowPeople(int num)
        {
            Console.WriteLine(box[num].name);
            Console.WriteLine(box[num].age);
            Console.WriteLine(box[num].Status);
        }
    }
}
