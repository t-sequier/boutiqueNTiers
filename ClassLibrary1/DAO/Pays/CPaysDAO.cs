using ClassLibrary1.Objets;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1.DAO
{
    public abstract class CPaysDAO : DAO<CPays, int>
    {
        public CPaysDAO(String connexionString) : base(connexionString) { }

        public override int create(CPays obj)
        {
            return 0;
        }

        public override List<CPays> getAll()
        {
            List<CPays> lstAll = new List<CPays>();

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM PAYS";

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int id = int.Parse(res["id"].ToString());
                String nom = (res["nom"].ToString());
                lstAll.Add(new CPays(id, nom));


            }
            res.Close(); //fermeture lecteur BD
            return lstAll;
        }

        public override Boolean update(CPays obj)
        {
            return true;
        }

        public override Boolean delete(CPays obj)
        {
            return true;
        }

        public override CPays find(int id)
        {
            CPays tmp = null;

            return tmp;
        }
    }
}
