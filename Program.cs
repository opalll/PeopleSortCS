using System;
using testcs;

Console.WriteLine("Enter \"END\" if you want to stop");
while (true)
{
    string name = Console.ReadLine();
    if (name == "END")
        break;
    int age = Convert.ToInt32(Console.ReadLine());
    PeopleSort people = new PeopleSort(name, age);
    PeopleSort.CheckIn(people);
}

while(true)
{
    int num = Convert.ToInt32(Console.ReadLine());
    PeopleSort.ShowPeople(num);
}