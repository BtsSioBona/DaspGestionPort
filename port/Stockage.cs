using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navire_interface
{
    public class Stockage
    {
        private int _capaTotal;
        private int _capaStocke;

        public Stockage(int capaTotal)
        {
            if (capaTotal > 0)
                this._capaTotal = capaTotal;
            else
                throw new Exception("La quantité de stockage ne peut être négative ou nulle");
        }

        public int CapaDispo
        {
            get { return this._capaTotal - this._capaStocke; }
        }
        public int CapaTotal
        {
            get { return this._capaTotal; }
        }

        public void Stocker(int qte)
        {
            if (qte <= 0)
                throw new Exception("La quantité a decharger doit être positif et supérieur à 0");
            else
                this._capaStocke += qte;
        }

        public bool estVide()
        {
            return this._capaStocke == 0;
        }

        public bool estRemplie()
        {
            return this._capaTotal == this._capaStocke;
        }
    }
}
