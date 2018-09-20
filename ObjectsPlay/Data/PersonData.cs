using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObjectsPlay.Objects;

namespace ObjectsPlay.Data
{
    class PersonData
    {
        enum Gender
        {
            Male, Female
        }
        public Person GetPerson(int i)
        {
            return new Person
            {
                FirstName = "John" + i,
                LastName = "Doe" + i,
                Gender = Gender.Male.ToString(),
                HomeTown = "Odense" + i,
                YearOfBirth = 2005
            };
        }

        public Person[] GetPersons()
        {
            Person[] persons = new Person[5];
            for(int i = 0; i < 4; i++)
            {
                persons[i] = GetPerson(i);
            }
            Person female = new Person
            {
                FirstName = "Jane",
                LastName = "Doe",
                Gender = Gender.Female.ToString(),
                HomeTown = "Nyborg",
                YearOfBirth = 1998
            };
            persons[4] = female;

            return persons;
        }

        public List<Person> GetAllPersons()
        {
            List<Person> personsList = new List<Person>();
            //add a person to the list
            //personsList.Add()

            return personsList;
        }

    }
}
