using ClassLibrary1.Objets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

public partial class WebService : System.Web.Services.WebService
{
    [WebMethod]
    public List<CClient> getTousLesClients()
    {
        List<CClient> CClients = new List<CClient>();
        CClients = ClassLibrary1.DAO.DAOFactory.getCClients().getAll();
        return CClients;
    }

    //TODO
    [WebMethod]
    public List<CClient> getUnClient()
    {
        List<CClient> CClient = new List<CClient>();
        CClient = ClassLibrary1.DAO.DAOFactory.getCClients().getUn();
        return CClient;
    }

    /*
     * TODO : Ajout Client
    [WebMethod]
    public List<CClient> getTousLesClients()
    {
        List<CClient> CClients = new List<CClient>();
        CClients = ClassLibrary1.DAO.DAOFactory.getCClients().getAll();
        return CClients;
    }
    */
    /*
     * TODO : Modif Client
    [WebMethod]
    public List<CClient> getTousLesClients()
    {
        List<CClient> CClients = new List<CClient>();
        CClients = ClassLibrary1.DAO.DAOFactory.getCClients().getAll();
        return CClients;
    }
    */
    /*
     * TODO : Supp Client
    [WebMethod]
    public List<CClient> getTousLesClients()
    {
        List<CClient> CClients = new List<CClient>();
        CClients = ClassLibrary1.DAO.DAOFactory.getCClients().getAll();
        return CClients;
    }
    */
}
    