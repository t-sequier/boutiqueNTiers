using ClassLibrary1.Objets;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1.DAO
{
    public abstract class CStatutCommandeDAO : DAO<CStatutCommande, int>
    {
        public CStatutCommandeDAO(String connexionString) : base(connexionString) { }

        public override int create(CStatutCommande obj)
        {
            return 0;
        }

        public override List<CStatutCommande> getAll()
        {
            List<CStatutCommande> lstAll = new List<CStatutCommande>();

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM STATUT_COMMANDE";

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int id = int.Parse(res["id"].ToString());
                String libelle = (res["libelle"].ToString());
                String fini = (res["fini"].ToString());
                int ordre = int.Parse(res["ordre"].ToString());
                lstAll.Add(new CStatutCommande(id, libelle, fini, ordre));


            }
            res.Close(); //fermeture lecteur BD
            return lstAll;
        }

        public List<CStatutCommande> getUn(int idStatut)
        {
            List<CStatutCommande> lstAll = new List<CStatutCommande>();

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM STATUT_COMMANDE WHERE ID =" + idStatut;

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int id = int.Parse(res["id"].ToString());
                String libelle = (res["libelle"].ToString());
                String fini = (res["fini"].ToString());
                int ordre = int.Parse(res["ordre"].ToString());
                lstAll.Add(new CStatutCommande(id, libelle, fini, ordre));
            }
            res.Close(); //fermeture lecteur BD
            return lstAll;
        }

        public override Boolean update(CStatutCommande obj)
        {
            return true;
        }

        public override Boolean delete(CStatutCommande obj)
        {
            return true;
        }

        public override CStatutCommande find(int id)
        {
            CStatutCommande tmp = null;

            return tmp;
        }
    }
}
