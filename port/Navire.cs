using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navire_interface
{
    public class Navire
    {
        private string _noLloyds;
        private string _nomNavire;
        private string _libelleFret;
        private int _qteFret;

        public Navire(string noLloyds, string nomNavire, string libelleFret, int qteFret)
        {
            this._noLloyds = noLloyds;
            this._nomNavire = nomNavire;
            this._libelleFret = libelleFret;
            if (qteFret > 0)
                this._qteFret = qteFret;
            else
                throw new Exception("La quantité de frêt doit être supérieure à 0");
        }

        public int QteFret
        {
            get { return this._qteFret; }
        }

        public void Decharger(int qte)
        {
            if(qte <= 0)
                throw new Exception("La quantité a decharger doit être positif et supérieur à 0");
            else if(qte <= this._qteFret)
                this._qteFret -= qte;
            else
                throw new Exception("La quantité a décharger est superieur à la quantité du fret");
        }

        public bool estDecharge()
        {
            return this._qteFret == 0;
        }

    }
}
