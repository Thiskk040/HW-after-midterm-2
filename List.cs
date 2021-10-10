using System;
using System.Collections.Generic;
namespace ActivityProgram001
{
    class PersonList
    {
        private List<Person> personList;

        public PersonList()
        {
            this.personList = new List<Person>();
        }

        public void AddNewPerson(Person person)
        {
            this.personList.Add(person);
        }

        public void FetchPersonsList()
        {
            Console.WriteLine("List Persons");
            Console.WriteLine("---------------------");
            foreach (Person person in this.personList)
            {
                if (person is Student)
                {
                    Console.WriteLine("Name: {0}", person.GetName());
                    Console.WriteLine("  Type: Student");
                    Console.WriteLine("  Activity : {0}", person.GetActivity());
                    Console.WriteLine("  Exp evaluate activity day: {0}/{1}/{2}",person.GetExpDay(),person.GetMonth(),person.GetYear()+1);
                }

                else if (person is Teacher)
                {
                    Console.WriteLine("Name: {0}", person.GetName());
                    Console.WriteLine("  Type: Teacher");
                    Console.WriteLine("  Activity : {0}", person.GetActivity());
                    Console.WriteLine("  Exp evaluate activity day: {0}/{1}/{2}", person.GetExpDay(), person.GetMonth(), person.GetYear()+1);

                }
            }
        }
    }
}
