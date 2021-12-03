using ClassLibrary2.Objets;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary2.DAO
{
    public abstract class CFraisPortDAO : DAO<CFraisPort, int>
    {
        public CFraisPortDAO(String connexionString) : base(connexionString) { }

        public override int create(CFraisPort obj)
        {
            return 0;
        }

        public override List<CFraisPort> getAll()
        {
            List<CFraisPort> lstAll = new List<CFraisPort>();

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM FRAIS_PORT";

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int id = int.Parse(res["id"].ToString());
                int poidsMax = int.Parse(res["poids_maxi"].ToString());
                int prix = int.Parse(res["prix"].ToString());
                lstAll.Add(new CFraisPort(id, poidsMax, prix));
            }
            res.Close(); //fermeture lecteur BD
            return lstAll;
        }

        public List<CFraisPort> getUn(int idFP)
        {
            List<CFraisPort> lstAll = new List<CFraisPort>();

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM FRAIS_PORT WHERE ID =" + idFP;

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int id = int.Parse(res["id"].ToString());
                int poidsMax = int.Parse(res["poids_maxi"].ToString());
                int prix = int.Parse(res["prix"].ToString());
                lstAll.Add(new CFraisPort(id, poidsMax, prix));
            }
            res.Close(); //fermeture lecteur BD
            return lstAll;
        }

        public override Boolean update(CFraisPort obj)
        {
            return true;
        }

        public override Boolean delete(CFraisPort obj)
        {
            return true;
        }

        public override CFraisPort find(int id)
        {
            CFraisPort tmp = null;

            return tmp;
        }
    }
}
