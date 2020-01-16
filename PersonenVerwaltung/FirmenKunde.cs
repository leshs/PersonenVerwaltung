using System;
using System.Collections.Generic;
using System.Text;

namespace PersonenVerwaltung
{
    class FirmenKunde : Person
    {
        public string Position;
        public string Abteilung;
        public FirmenKunde(int ID, string Vorname, string Nachname, string Adresse, string Position, string Abteilung) : base (ID, Vorname, Nachname, Adresse)
        {
            this.Position = Position;
            this.Abteilung = Abteilung;
        }

        public override string getInfo()
        {
            return ID + ", " + Vorname + " " + Nachname + ", " + Adresse + ", " +Abteilung + ", " + Position; 
        }
    }
}
