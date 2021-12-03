using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Objets
{
    public class CDepartements
    {
        int id;
        String nom;

        /*Acesseur*/
        public int Id { get { return this.id; } set { this.id = value; } }
        public String Nom { get { return this.nom; } set { this.nom = value; } }

        public CDepartements() { this.id = 1; this.nom = "unset"; }

        /*Constructeur*/
        public CDepartements(int id, String nom)
        {
            this.id = id;
            this.nom = nom;
        }
    }
}
