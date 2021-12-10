using ClassLibrary1.Objets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

public partial class WebService : System.Web.Services.WebService
{
    [WebMethod]
    public List<CVilles> getToutesLesVilles(int idDepartement)
    {
        List<CVilles> CVilles = new List<CVilles>();
        CVilles = ClassLibrary1.DAO.DAOFactory.getCVilles().getAll(idDepartement);
        return CVilles;
    }
}