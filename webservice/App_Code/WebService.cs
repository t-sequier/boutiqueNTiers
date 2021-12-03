using System;
using System.Collections.Generic;
using ClassLibrary2.DAO;
using ClassLibrary2.Objets;
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
        List<CPays> retour = ClassLibrary2.DAO.DAOFactory.getCPaysDAO().getAll();
        return "salut "+nom+" !";
    }

    [WebMethod]
    public float Test(float a, float b)
    {
        return a+b;
    }

    [WebMethod(Description = "Charge tous les Pays")]
    public List<CPays> GetAllPays()
    {
        List<CPays> retour = new List<CPays>();
        retour = DAOFactory.getCPaysDAO().getAll();
        return retour;
    }

    [WebMethod(Description = "Charge toutes les rubriques")]
    public List<CRubrique> GetAllRubriques()
    {
        List<CRubrique> retour = new List<CRubrique>();
        retour = DAOFactory.getCRubriqueDAO().getAll();
        return retour;
    }

    [WebMethod(Description = "Charge toutes les clients")]
    public List<CClient> GetAllClient()
    {
        List<CClient> retour = new List<CClient>();
        retour = DAOFactory.getCClientDAO().getAll();
        return retour;
    }

    [WebMethod(Description = "Charge toutes les rubriques")]
    public List<CArticles> GetAllArticles()
    {
        List<CArticles> retour = new List<CArticles>();
        retour = DAOFactory.getCArticlesDAO().getAll();
        return retour;
    }

    [WebMethod(Description = "Charge toutes les lignes panier")]
    public List<CLignePanier> GetAllLignePanier()
    {
        List<CLignePanier> retour = new List<CLignePanier>();
        retour = DAOFactory.getCLignePanierDAO().getAll();
        return retour;
    }

    [WebMethod(Description = "ajoute une ligne au panier")]
    public int AddLignePanier(int numClient, String idArticle, int qte)
    {
        CLignePanier ligne = new CLignePanier(numClient, idArticle, qte);
        int result = DAOFactory.getCLignePanierDAO().create(ligne);
        return result;
    }

    [WebMethod(Description = "Charge toutes les lignes commande")]
    public List<CLigneCommande> GetAllCLigneCommande()
    {
        List<CLigneCommande> retour = new List<CLigneCommande>();
        retour = DAOFactory.getCLigneCommandeDAO().getAll();
        return retour;
    }

    [WebMethod]
    public List<CRegions> getToutesLesRegions(int idPays)
    {
        List<CRegions> CRegions = new List<CRegions>();
        CRegions = ClassLibrary2.DAO.DAOFactory.getCRegions().getAll(idPays);
        return CRegions;
    }

    [WebMethod]
    public List<CDepartements> getTousLesDepartements(int idRegion)
    {
        List<CDepartements> CDepartements = new List<CDepartements>();
        CDepartements = ClassLibrary2.DAO.DAOFactory.getCDepartements().getAll(idRegion);
        return CDepartements;
    }

    [WebMethod]
    public List<CVilles> getToutesLesVilles(int idDepartement)
    {
        List<CVilles> CVilles = new List<CVilles>();
        CVilles = ClassLibrary2.DAO.DAOFactory.getCVilles().getAll(idDepartement);
        return CVilles;
    }

    //Todo: Mettre les webmethod de commandes (frais_port, statut, ligne_commande, commande) dans un nouveau WS
    //----------Commandes------------
    [WebMethod]
    public List<CCommandes> getToutesLesCommandes()
    {
        List<CCommandes> CCommandes = new List<CCommandes>();
        CCommandes = ClassLibrary2.DAO.DAOFactory.getCCommandesDAO().getAll();
        return CCommandes;
    }

    [WebMethod]
    public List<CCommandes> getUneCommande(int idCommande)
    {
        List<CCommandes> CCommandes = new List<CCommandes>();
        CCommandes = ClassLibrary2.DAO.DAOFactory.getCCommandesDAO().getUn(idCommande);
        return CCommandes;
    }
    //----------Statut commande------------
    [WebMethod]
    public List<CStatutCommande> getTousLesStatutCommandes()
    {
        List<CStatutCommande> CStatutCommande = new List<CStatutCommande>();
        CStatutCommande = ClassLibrary2.DAO.DAOFactory.getCStatutCommandeDAO().getAll();
        return CStatutCommande;
    }

    [WebMethod]
    public List<CStatutCommande> getUnStatutCommande(int idStatut)
    {
        List<CStatutCommande> CStatutCommande = new List<CStatutCommande>();
        CStatutCommande = ClassLibrary2.DAO.DAOFactory.getCStatutCommandeDAO().getUn(idStatut);
        return CStatutCommande;
    }
    //----------Frais port------------
    [WebMethod]
    public List<CFraisPort> getTousLesFraisPort()
    {
        List<CFraisPort> CFraisPort = new List<CFraisPort>();
        CFraisPort = ClassLibrary2.DAO.DAOFactory.getCFraisPortDAO().getAll();
        return CFraisPort;
    }

    [WebMethod]
    public List<CFraisPort> getUnFraisPort(int idFP)
    {
        List<CFraisPort> CFraisPort = new List<CFraisPort>();
        CFraisPort = ClassLibrary2.DAO.DAOFactory.getCFraisPortDAO().getUn(idFP);
        return CFraisPort;
    }
}
