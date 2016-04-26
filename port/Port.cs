using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navire_interface
{
    public class Port
    {
        private List<Stockage> _stockages;
        public Port()
        {
            this._stockages = new List<Stockage>();
        }

        public void Dechargement(Navire unNavire)
        {
            Stockage stockage;
            for (int i =0; !unNavire.estDecharge() && i < this._stockages.Count; i++)
            {
                stockage = this._stockages[i];
                if(unNavire.QteFret >= stockage.CapaDispo)
                {
                    unNavire.Decharger(stockage.CapaDispo);
                    stockage.Stocker(stockage.CapaDispo);
                }
                else
                {
                    stockage.Stocker(stockage.CapaDispo - unNavire.QteFret);
                    unNavire.Decharger(unNavire.QteFret);
                }
            }
            if (unNavire.QteFret > 0)
                throw new Exception("La navire n'a pu être déchargé, il reste " + unNavire.QteFret + " à décharger");
        }

        public void AddStockage(int capaTotal)
        {
            this._stockages.Add(new Stockage(capaTotal));
        }

        public List<Stockage> Stockages
        {
            get { return this._stockages; }
        }
    }
}
