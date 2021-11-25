using ClassLibrary1.Objets;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1.DAO.Client
{
    public abstract class CClientDAO : DAO<CClient, int>
    {
        public CClientDAO(String connexionString) : base(connexionString) { }

        public override int create(CClient obj)
        {
            return 0;
        }

        //récupère la liste de tous les clients (uniquement l'id (numero) et le nom)
        public override List<CClient> getAll()
        {
            List<CClient> lstAll = new List<CClient>();

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM CLIENT";

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int id          = int.Parse(res["numero"].ToString());
                String nom      = (res["nom"].ToString());
                String prenom   = (res["prenom"].ToString());
                String numAdr   = (res["adresse_numero"].ToString());
                String rueAdr   = (res["adresse_rue"].ToString());
                int cp          = int.Parse(res["code_postal"].ToString());
                String email    = (res["email"].ToString());
                String tel      = (res["tel"].ToString());
                int civ         = int.Parse(res["id_civilite"].ToString());

                lstAll.Add(new CClient(id, nom, prenom, numAdr, rueAdr, cp, email, tel, civ));
            }

            res.Close(); //fermeture lecteur BD

            return lstAll;
        }

        //TODO : récupère les infos d'un client dont l'id (numero) est précisé en paramètre
        public List<CClient> getUn(int idClient)
        {
            List<CClient> lstUn = new List<CClient>();

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM CLIENT WHERE NUMERO =" + idClient;

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int id = int.Parse(res["numero"].ToString());
                String nom = (res["nom"].ToString());
                String prenom = (res["prenom"].ToString());
                String numAdr = (res["adresse_numero"].ToString());
                String rueAdr = (res["adresse_rue"].ToString());
                int cp = int.Parse(res["code_postal"].ToString());
                String email = (res["email"].ToString());
                String tel = (res["tel"].ToString());
                int civ = int.Parse(res["id_civilite"].ToString());
                lstUn.Add(new CClient(id, nom, prenom, numAdr, rueAdr, cp, email, tel, civ));
            }
            res.Close(); //fermeture lecteur BD
            return lstUn;
        }

        public override Boolean update(CClient obj)
        {
            return true;
        }

        public override Boolean delete(CClient obj)
        {
            return true;
        }

        public override CClient find(int id)
        {
            CClient tmp = null;
            return tmp;
        }
    }
}
