using System;
using System.Collections.Generic;
using System.Text;

namespace PersonenVerwaltung
{
    class PersonView
    {
        PersonStore personStore = new PersonStore();
        AnzeigeTafel anzeigeTafel1 = new AnzeigeTafel();
        Person person = new Person(1, "Person1", "Nachname1", "Adresse1");
        FirmenKunde firmenKunde = new FirmenKunde(2, "Firmenkunde1", "Nachname2", "Firmenadresse", "Position", "Abteilung");


        public void Foo()
        {
            personStore.EditPersonListVar += anzeigeTafel1.PersonenAnzeigen;

            //Hinzufügen
            Console.WriteLine("Person1 hinzugefügt:");
            personStore.AddPerson(person);

            Console.WriteLine();

            Console.WriteLine("Firmenkunde hinzugefügt:");
            personStore.AddPerson(firmenKunde);

            Console.WriteLine();

            //Löschen
            Console.WriteLine("Person1 gelöscht");
            personStore.RemovePerson(person);

            Console.WriteLine();

            //Editieren
            Console.WriteLine("Firmenkunde geändert");
            firmenKunde.Nachname = "neuer Nachname";
            personStore.EditPerson(firmenKunde);

        }
    }
}
