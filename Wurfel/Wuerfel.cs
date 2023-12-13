using System;

namespace Wurfel
{
    public class Wuerfeln
    {
        Random zufallzahl = new Random();
        int aktuellerWurf;
        int letzterWurf;

        public int werfen()
        {
            letzterWurf = aktuellerWurf;
            aktuellerWurf = zufallzahl.Next (1, 7);
            return aktuellerWurf;
        }

        public int LetzterWurf
        {
            get { return letzterWurf; }
        }
    }
}

