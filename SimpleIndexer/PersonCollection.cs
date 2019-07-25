using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SimpleIndexer
{
    public class PersonCollection : IEnumerable
    {
        private Dictionary<string, Person> listPeople = new Dictionary<string, Person>();
        public Person this[string name]
        {
            get => (Person)listPeople[name];
            set => listPeople[name] = value;
        }
        // Cast for caller.
        public Person GetPerson(string name) => (Person)listPeople[name];
        // Insert only Person objects.
        public void AddPerson(string k, Person p)
        { listPeople.Add(k, p); }
        public void ClearPeople()
        { listPeople.Clear(); }

        public int Count => listPeople.Count;
        // Foreach enumeration support.
        IEnumerator IEnumerable.GetEnumerator() => listPeople.GetEnumerator();
    }
}
