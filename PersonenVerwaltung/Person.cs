using System;
using System.Collections.Generic;
using System.Text;

namespace PersonenVerwaltung
{
    class Person
    {
        public int ID;
        public string Vorname;
        public string Nachname;
        public string Adresse;

        public Person(int ID, string Vorname, string Nachname, string Adresse)
        {
            this.ID = ID;
            this.Vorname = Vorname;
            this.Nachname = Nachname;
            this.Adresse = Adresse;
        }
        public virtual string getInfo()
        {
            return ID + ", " + Vorname + " " + Nachname + ", " + Adresse;
        }
    }




}
