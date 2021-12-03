using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.DAO
{
    public class DAOFactory
    {
        protected static String _connexionString = "SERVER=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=tcp)(HOST = 10.5.0.41)(PORT=1521)))(CONNECT_DATA=(SID=XE)));uid=mms06;pwd=mms06;";

    
        public static _CPaysDAO getCPaysDAO()
        {
            return new _CPaysDAO(_connexionString);
        }

        public static _CRubriqueDAO getCRubriqueDAO()
        {
            return new _CRubriqueDAO(_connexionString);
        }

        public static _CClientDAO getCClientDAO()
        {
            return new _CClientDAO(_connexionString);
        }

        public static _CArticlesDAO getCArticlesDAO()
        {
            return new _CArticlesDAO(_connexionString);
        }

        public static _CLignePanierDAO getCLignePanierDAO()
        {
            return new _CLignePanierDAO(_connexionString);
        }

        public static _CLigneCommandeDAO getCLigneCommandeDAO()
        {
            return new _CLigneCommandeDAO(_connexionString);
        }

        public static _CRegionsDAO getCRegions()
        {
            return new _CRegionsDAO(_connexionString);
        }

        public static _CDepartementsDAO getCDepartements()
        {
            return new _CDepartementsDAO(_connexionString);
        }

        public static _CVillesDAO getCVilles()
        {
            return new _CVillesDAO(_connexionString);
        }

        public static _CCommandesDAO getCCommandesDAO()
        {
            return new _CCommandesDAO(_connexionString);
        }

        public static _CStatutCommandeDAO getCStatutCommandeDAO()
        {
            return new _CStatutCommandeDAO(_connexionString);
        }

        public static _CFraisPortDAO getCFraisPortDAO()
        {
            return new _CFraisPortDAO(_connexionString);
        }
    }
}
