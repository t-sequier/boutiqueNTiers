using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Objets
{
    public class CStatutCommande
    {
        int id;
        String libelle;
        String fini;
        int ordre;

        /*Accesseur*/
        public int Id { get { return this.id; } set { this.id = value; } }
        public String Libelle { get { return this.libelle; } set { this.libelle = value; } }
        public String Fini { get { return this.fini; } set { this.fini = value; } }
        public int Ordre { get { return this.ordre; } set { this.ordre = value; } }


        public CStatutCommande() { this.id = 1; this.libelle = "unset"; this.fini = "unset"; this.ordre = 1; }

        /*Constructeur*/
        public CStatutCommande(int id, String libelle, String fini, int ordre)
        {
            this.id = id;
            this.libelle = libelle;
            this.fini = fini;
            this.ordre = ordre;
        }
    }
}
