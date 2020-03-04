using System;
using System.Collections.Generic;
using System.Text;

namespace Harcosok
{
    class Harcos
    {
        private string nev;
        private int eletero;
        private int harciero;

        public Harcos(string nev, int eletero, int harciero)
        {
            this.nev = nev;
            this.eletero = eletero;
            this.harciero = harciero;
        }

        public bool harcol(Harcos harcos)
        {
            eletero -= harcos.getHarciero();
            harcos.setEletero(harcos.getEletero() - harciero);

            if (eletero <= 0 || harcos.getEletero() <= 0)
            {
                return true;
            }

            return false;
        }

        public string toString()
        {
            return $"{nev}(Harcierő: {harciero}, Életerő: {eletero})";
        }

        #region Getters & Setters
        public string getNev()
        {
            return nev;
        }

        public int getEletero()
        {
            return eletero;
        }
        public int getHarciero()
        {
            return harciero;
        }
        public void setNev(string nev)
        {
            this.nev = nev;
        }
        public void setEletero(int eletero)
        {
            this.eletero = eletero;
        }
        public void setHarciero(int harciero)
        {
            this.harciero = harciero;
        }
        #endregion
    }
}
