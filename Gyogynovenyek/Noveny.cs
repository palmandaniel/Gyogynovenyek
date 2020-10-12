namespace Gyogynovenyek
{
    internal class Noveny
    {
        public string Nev { get; private set; }
        public string Resz { get; private set; }
        public int Kezd { get; private set; }
        public int Veg { get; private set; }
        public int Idotartam { get; private set; }

        public Noveny(string szoveg)
        {
            string[] adatok = szoveg.Split(';');
            Nev = adatok[0] ;
            Resz = adatok[1] ;
            Kezd = int.Parse(adatok[2]);
            Veg = int.Parse(adatok[3]);

            if (Kezd<Veg)
            {
                Idotartam = (Veg - Kezd) + 1;
            }
            else
            {
                Idotartam = ((12 - Kezd) + Veg) + 1;
            }
            
        }
    }
}