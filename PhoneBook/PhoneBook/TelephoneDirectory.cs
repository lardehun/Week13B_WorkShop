using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class TelephoneDirectory : IEnumerable
    {
        static int maxNumberOfDirectory = 50;
        List<Person> personList;
        public TelephoneDirectory()
        {
            personList = new List<Person>();
        }

        public List<Person> PersonList
        {
            get
            {
                return personList;
            }

            set
            {
                personList = value;
            }
        }

        public bool addToTelephoneDirectory(Person person)
        {
            if (personList.Count != maxNumberOfDirectory)
            {
                personList.Add(person);
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)personList).GetEnumerator();
        }
    }
}
