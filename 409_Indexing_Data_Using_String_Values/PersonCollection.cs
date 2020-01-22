using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _409_Indexing_Data_Using_String_Values
{
    public class PersonCollection : IEnumerable
    {
        private Dictionary<string, Person> ListPeople = new Dictionary<string, Person>();

        public int Count
        {
            get => ListPeople.Count;
            set { }
        }

        public Person this[string name]
        {
            get => (Person)ListPeople[name];
            set => ListPeople[name] = value;
        }

        IEnumerator IEnumerable.GetEnumerator() => ListPeople.GetEnumerator();

        public void ClearPeople()
        {
            ListPeople.Clear();
        }
    }
}
