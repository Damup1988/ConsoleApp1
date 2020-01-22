using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _408_SimpleIndexer
{
    public class PersonCollection : IEnumerable
    {
        private ArrayList arPeople = new ArrayList();

        public int Count
        {
            //get { return arPeople.Count; }
            get => arPeople.Count;
            set { }
        }

        //a property of Person type - INDEXER
        public Person this[int index]
        {
            get => (Person)arPeople[index];
            set => arPeople.Insert(index, value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return arPeople.GetEnumerator();
        }

        /*public int Count()
        {
            return arPeople.Count;
        }*/
    }
}