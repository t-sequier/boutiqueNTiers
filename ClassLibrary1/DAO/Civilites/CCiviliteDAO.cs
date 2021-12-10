using ClassLibrary1.Objets;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1.DAO
{
    public abstract class CCiviliteDAO : DAO<CCivilite, int>
    {
        public CCiviliteDAO(String connexionString) : base(connexionString) { }

        public override int create(CCivilite obj)
        {
            return 0;
        }

        public override List<CCivilite> getAll()
        {
            List<CCivilite> lstAll = new List<CCivilite>();

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM CIVILITE";

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int id = int.Parse(res["id"].ToString());
                String libelle = res["libelle"].ToString();
                lstAll.Add(new CCivilite(id, libelle));
            }
            res.Close(); //fermeture lecteur BD
            return lstAll;
        }

        public List<CCivilite> getUn(int idCiv)
        {
            List<CCivilite> lstAll = new List<CCivilite>();

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM CIVILITE WHERE ID =" + idCiv;

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int id = int.Parse(res["id"].ToString());
                String libelle = res["libelle"].ToString();
                lstAll.Add(new CCivilite(id, libelle));
            }
            res.Close(); //fermeture lecteur BD
            return lstAll;
        }

        public override Boolean update(CCivilite obj)
        {
            return true;
        }

        public override Boolean delete(CCivilite obj)
        {
            return true;
        }

        public override CCivilite find(int id)
        {
            CCivilite tmp = null;

            return tmp;
        }
    }
}
