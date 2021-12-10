using ClassLibrary1.Objets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

public partial class WebService : System.Web.Services.WebService
{
    [WebMethod(Description = "Charge toutes les lignes panier")]
    public List<CLignePanier> GetAllLignePanier()
    {
        List<CLignePanier> retour = new List<CLignePanier>();
        retour = ClassLibrary1.DAO.DAOFactory.getCLignePanierDAO().getAll();
        return retour;
    }

    [WebMethod(Description = "ajoute une ligne au panier")]
    public int AddLignePanier(int numClient, String idArticle, int qte)
    {
        CLignePanier ligne = new CLignePanier(numClient, idArticle, qte);
        int result = ClassLibrary1.DAO.DAOFactory.getCLignePanierDAO().create(ligne);
        return result;
    }

    [WebMethod(Description = "récupère les lignes panier d'un client")]
    public List<CLignePanier> getLignePanierClient(int idClient)
    {
        List<CLignePanier> lignesPanierClient = new List<CLignePanier>();
        lignesPanierClient = ClassLibrary1.DAO.DAOFactory.getCLignePanierDAO().getByIDClient(idClient);
        return lignesPanierClient;
    }

    [WebMethod]
    public int paniertToCommande(int numClient)
    {
        CCommandes comm = new CCommandes();
        comm.IdCli = numClient;
        int result = ClassLibrary1.DAO.DAOFactory.getCCommandesDAO().create(comm);
        return result;
    }

    /*[WebMethod]
    public int deletePanier (int numClient)
    {
        
    }*/
}