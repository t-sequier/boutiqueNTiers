using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.DAO
{
    public class _CArticlesDAO : CArticlesDAO
    {
        public _CArticlesDAO(String connexionString) : base(connexionString) { }

        /**public List<CRegion> getRegion(CPays pays)
        {
            return DAOFactory.getCPaysDAO().getRegion(pays);
        }**/
    }
}
