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
        String prenom;
        String numAdr;
        String rueAdr;
        int cp;
        String email;
        String tel;
        int civ;

        /*Acesseur*/
        public int Id { get { return this.id; } set { this.id = value; } }
        public String Nom { get { return this.nom; } set { this.nom = value; } }
        public String Prenom { get { return this.prenom; } set { this.prenom = value; } }
        public String NumAdr { get { return this.numAdr; } set { this.numAdr = value; } }
        public String RueAdr { get { return this.rueAdr; } set { this.rueAdr = value; } }
        public int Cp { get { return this.cp; } set { this.cp = value; } }
        public String Email { get { return this.email; } set { this.email = value; } }
        public String Tel { get { return this.tel; } set { this.tel = value; } }
        public int Civ { get { return this.civ; } set { this.civ = value; } }

        public CClient()
        {
            this.id = 1;
            this.nom = "unset";
            this.prenom = "unset";
            this.numAdr = "unset";
            this.rueAdr = "unset";
            this.cp = 1;
            this.email = "unset";
            this.tel = "unset";
            this.civ = 1;
        }

        /*Constructeur*/
        public CClient(int id, String nom, String prenom, String numAdr, String rueAdr, int cp, String email, String tel, int civ)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.numAdr = numAdr;
            this.rueAdr = rueAdr;
            this.cp = cp;
            this.email = email;
            this.tel = tel;
            this.civ = civ;
        }
    }
}
