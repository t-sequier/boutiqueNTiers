using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Objets
{
    public class CClient
    {
        int id;
        String nom;

        /*Acesseur*/
        public int Id { get { return this.id; } set { this.id = value; } }
        public String Nom { get { return this.nom; } set { this.nom = value; } }

        public CClient() { this.id = 1; this.nom = "unset"; }

        /*Constructeur*/
        public CClient(int id, String nom)
        {
            this.id = id;
            this.nom = nom;
        }
    }
}
