using ClassLibrary1.Objets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

public partial class WebService : System.Web.Services.WebService
{
    [WebMethod]
    public List<CRubrique> getToutesLesRubriques()
    {

        List<CRubrique> CRubrique = new List<CRubrique>();
        CRubrique = ClassLibrary1.DAO.DAOFactory.getCRubriquesDAO().getAll();
        return CRubrique;
    }
}