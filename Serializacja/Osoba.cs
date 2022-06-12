using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Serializacja
{
    [Serializable]
    internal class Osoba
    {
        int pesel;
        string nazwisko;
        string imie;

        [NonSerialized] double dochod;

        public Osoba(string imię, string nazwisko, int pesel, double dochod)
        {
            this.pesel = pesel;
            this.nazwisko = nazwisko;
            this.imie = imię;
            this.dochod = dochod;
        }

        public override string ToString()
        {
            return String.Format("PESEL = '{0}' ", pesel) +
            String.Format("Nazwisko = '{0}' ", nazwisko) +
            String.Format("Imie = '{0}' ", imie) +
            String.Format("Dochód = '{0}' ", dochod );
        }
        public static void Serializacja(Osoba o,string nazwaPliku)
        {
            Stream strumien;
            strumien = File.Open(nazwaPliku, FileMode.Create);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(strumien, o);
            strumien.Close();
        }
        public static Osoba DeSerializacja(string nazwaPliku)
        {
            
            Stream strumien;
            strumien = File.Open(nazwaPliku, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            Osoba o = (Osoba)bf.Deserialize(strumien);

            return o;
        }
    }
}
