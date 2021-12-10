using ClassLibrary1.Objets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

public partial class WebService : System.Web.Services.WebService
{
    [WebMethod(Description = "Charge toutes les lignes commande")]
    public List<CLigneCommande> GetAllCLigneCommande()
    {
        List<CLigneCommande> retour = new List<CLigneCommande>();
        retour = ClassLibrary1.DAO.DAOFactory.getCLigneCommandeDAO().getAll();
        return retour;
    }

    [WebMethod]
    public List<CCommandes> getToutesLesCommandes()
    {
        List<CCommandes> CCommandes = new List<CCommandes>();
        CCommandes = ClassLibrary1.DAO.DAOFactory.getCCommandesDAO().getAll();
        return CCommandes;
    }

    [WebMethod]
    public List<CCommandes> getUneCommande(int idCommande)
    {
        List<CCommandes> CCommandes = new List<CCommandes>();
        CCommandes = ClassLibrary1.DAO.DAOFactory.getCCommandesDAO().getUn(idCommande);
        return CCommandes;
    }
    //----------Statut commande------------
    [WebMethod]
    public List<CStatutCommande> getTousLesStatutCommandes()
    {
        List<CStatutCommande> CStatutCommande = new List<CStatutCommande>();
        CStatutCommande = ClassLibrary1.DAO.DAOFactory.getCStatutCommandeDAO().getAll();
        return CStatutCommande;
    }

    [WebMethod]
    public List<CStatutCommande> getUnStatutCommande(int idStatut)
    {
        List<CStatutCommande> CStatutCommande = new List<CStatutCommande>();
        CStatutCommande = ClassLibrary1.DAO.DAOFactory.getCStatutCommandeDAO().getUn(idStatut);
        return CStatutCommande;
    }

}