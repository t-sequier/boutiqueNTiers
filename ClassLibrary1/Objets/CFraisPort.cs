using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Objets
{
    public class CFraisPort
    {
        int id;
        int poidsMax;
        int prix;

        /*Accesseur*/
        public int Id { get { return this.id; } set { this.id = value; } }
        public int PoidsMax { get { return this.poidsMax; } set { this.poidsMax = value; } }
        public int Prix { get { return this.prix; } set { this.prix = value; } }


        public CFraisPort() { this.id = 1; this.poidsMax = 1; this.prix = 1; }

        /*Constructeur*/
        public CFraisPort(int id, int poidsMax, int prix)
        {
            this.id = id;
            this.poidsMax = poidsMax;
            this.prix = prix;
        }
    }
}
