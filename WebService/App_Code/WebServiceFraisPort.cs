using ClassLibrary1.Objets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

public partial class WebService : System.Web.Services.WebService
{
    [WebMethod]
    public List<CFraisPort> getTousLesFraisPort()
    {
        List<CFraisPort> CFraisPort = new List<CFraisPort>();
        CFraisPort = ClassLibrary1.DAO.DAOFactory.getCFraisPortDAO().getAll();
        return CFraisPort;
    }

    [WebMethod]
    public List<CFraisPort> getUnFraisPort(int idFP)
    {
        List<CFraisPort> CFraisPort = new List<CFraisPort>();
        CFraisPort = ClassLibrary1.DAO.DAOFactory.getCFraisPortDAO().getUn(idFP);
        return CFraisPort;
    }
}