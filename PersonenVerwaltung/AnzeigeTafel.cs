using System;
using System.Collections.Generic;
using System.Text;

namespace PersonenVerwaltung
{
    class AnzeigeTafel
    {
        public void PersonenAnzeigen(List<Person> personenListe)
        {
            foreach(Person person in personenListe)
            {
                Console.WriteLine(person.getInfo());
            }
        }   
    }
}
