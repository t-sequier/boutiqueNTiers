using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Objets
{
    public class CCommandes
    {
        int idCom;
        int idCli;
        int idStat;
        int idFP;

        /*Accesseur*/
        public int IdCom { get { return this.idCom; } set { this.idCli = value; } }
        public int IdCli { get { return this.idCli; } set { this.idCli = value; } }
        public int IdStat { get { return this.idStat; } set { this.idStat = value; } }
        public int IdFP { get { return this.idFP; } set { this.idFP = value; } }

        public CCommandes() { this.idCom = 1; this.idCli = 1; this.idStat = 1; this.idFP = 1; }

        /*Constructeur*/
        public CCommandes(int idCom, int idCli, int idStat, int idFP)
        {
            this.idCom = idCom;
            this.idCli = idCli;
            this.idStat = idStat;
            this.idFP = idFP;
        }
    }
}
