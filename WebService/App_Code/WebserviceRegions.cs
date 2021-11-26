using ClassLibrary1.Objets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

public partial class WebService : System.Web.Services.WebService
{
    [WebMethod]
    public List<CRegions> getToutesLesRegions(int idPays)
    {

        List<CRegions> CRegions = new List<CRegions>();
        CRegions = ClassLibrary1.DAO.DAOFactory.getCRegionsDAO().getAll(idPays);
        return CRegions;
    }
}