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

    [WebMethod]
    public Boolean updateClient(CClient clientAModifier)
    {
        Boolean reponse;
        try
        {
            ClassLibrary1.DAO.DAOFactory.getCClients().update(clientAModifier);
            reponse = true;
        }
        catch (Exception e)
        {
            reponse = false;
        }
        return reponse;
    }

    [WebMethod]
    public int addClient(CClient clientAAjouter)
    {
        int reponse;
        try
        {
            ClassLibrary1.DAO.DAOFactory.getCClients().create(clientAAjouter);
            reponse = 1;
        }
        catch (Exception e)
        {
            reponse = 0;
        }
        return reponse;
    }

    [WebMethod]
    public Boolean deleteClient(CClient clientASupprimer)
    {
        Boolean reponse;
        try
        {
            ClassLibrary1.DAO.DAOFactory.getCClients().delete(clientASupprimer);
            reponse = true;
        }
        catch (Exception e)
        {
            reponse = false;
        }
        return reponse;
    }
}