using ClassLibrary1.Objets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

public class WebService : System.Web.Services.WebService
{
    [WebMethod]
    public List<CClient> getTousLesClients()
    {
        List<CClient> CClients = new List<CClient>();
        CClients = ClassLibrary1.DAO.DAOFactory.getCClients().getAll();
        return CClients;
    }
}
    