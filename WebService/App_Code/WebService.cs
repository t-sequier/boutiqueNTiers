using ClassLibrary1.Objets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Description résumée de WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
// [System.Web.Script.Services.ScriptService]
public partial class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Supprimez les marques de commentaire dans la ligne suivante si vous utilisez des composants conçus 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld(String nom)
    {
        return "Salut " + nom + "!";
    }

    [WebMethod]
    public List<CPays> getTousLesPays()
    {
        
        List<CPays> CPays = new List<CPays>();
        CPays = ClassLibrary1.DAO.DAOFactory.getCPaysDAO().getAll();
        return CPays;
    }

    [WebMethod]
    public List<CRegions> getToutesLesRegions(int idPays)
    {
        List<CRegions> CRegions = new List<CRegions>();
        CRegions = ClassLibrary1.DAO.DAOFactory.getCRegions().getAll(idPays);
        return CRegions;
    }

    [WebMethod]
    public List<CDepartements> getTousLesDepartements(int idRegion)
    {
        List<CDepartements> CDepartements = new List<CDepartements>();
        CDepartements = ClassLibrary1.DAO.DAOFactory.getCDepartements().getAll(idRegion);
        return CDepartements;
    }

    [WebMethod]
    public List<CVilles> getToutesLesVilles(int idDepartement)
    {
        List<CVilles> CVilles = new List<CVilles>();
        CVilles = ClassLibrary1.DAO.DAOFactory.getCVilles().getAll(idDepartement);
        return CVilles;
    }

    //Todo: Mettre les webmethod de commandes (frais_port, statut, ligne_commande, commande) dans un nouveau WS
    //----------Commandes------------
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
    //----------Frais port------------
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
