using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.DAO
{
    public abstract class CRubriqueDAO : DAO<CRubrique, int>
    {
        public CRubriqueDAO(String connexionString) : base(connexionString) { }

        public override int create(CRubrique obj)
        {
            return 0;
        }

        public override List<CPays> getAll()
        {
            List<CRubrique> lstAll = new List<CRubrique>();

            //lstAll.Add(new CPays; 

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "select id, nom from pays";

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int id = int.Parse(res["id"].ToString());
                String nom = res["nom"].ToString();
                lstAll.Add(new CRubrique(id, nom));
            }
            res.Close();


            return lstAll;
        }

        public override Boolean update(CRubrique obj)
        {
            return true;
        }

        public override Boolean delete(CRubrique obj)
        {
            return true;
        }

        public override CRubrique find(int id)
        {
            CRubrique tmp = null;

            return tmp;
        }
    }
}
