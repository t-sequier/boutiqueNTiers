using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Objets
{
    public class CCivilite
    {
        int id;
        String libelle;

        /*Accesseur*/
        public int Id { get { return this.id; } set { this.id = value; } }
        public String Libelle { get { return this.libelle; } set { this.libelle = value; } }


        public CCivilite() { this.id = 1; this.libelle = "unset"; }

        /*Constructeur*/
        public CCivilite(int id, String libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }
    }
}
