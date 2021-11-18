using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Classe qui permet d'instancier des objets en étant appelée*/
namespace ClassLibrary1.DAO
{
    public class DAOFactory
    {
        protected static String _connexionString = "SERVER=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=tcp)(HOST = 10.5.0.41)(PORT=1521)))(CONNECT_DATA=(SID=XE)));uid=mms06;pwd=mms06;";


        public static _CPaysDAO getCPaysDAO()
        {
            return new _CPaysDAO(_connexionString);
        }

        public static _CRegionsDAO getCRegions()
        {
            return new _CRegionsDAO(_connexionString);
        }

        public static _CClientDAO getCClients()
        {
            return new _CClientDAO(_connexionString);
        }
    }
}
