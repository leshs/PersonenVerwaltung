using System;
using System.Collections.Generic;
using System.Text;

namespace PersonenVerwaltung
{
    class PersonStore
    {
        public List<Person> PersonenListe = new List<Person>();
        public delegate void EditPersonList(List<Person> personenListe);
        public event EditPersonList EditPersonListVar;

        public void AddPerson(Person person)
        {
            PersonenListe.Add(person);
            PersonListEdited();
        }

        public void RemovePerson(Person person)
        {
            for (int i = 0; i < PersonenListe.Count; i++)
            {
                {
                    if (PersonenListe[i].ID == person.ID)
                    {
                        PersonenListe.RemoveAt(i);
                        break;
                    }
                }
            }
            PersonListEdited();
        }

        public void EditPerson(Person person)
        {
            for (int i = 0; i < PersonenListe.Count; i++)
            {
                {
                    if (PersonenListe[i].ID == person.ID)
                    {
                        PersonenListe[i] = person;
                        break;
                    }
                }
            }
            PersonListEdited();
        }

        public void PersonListEdited()
        {
            if(EditPersonListVar != null)
            {
                EditPersonListVar.Invoke(PersonenListe);
            }
        }
    }
}
