using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace EmploidutempsWS
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        C_BASE labase = new C_BASE();

        
        [WebMethod]
       public List<C_Cours> DonneCours()
       {
            return labase.Get_all_cours1().ToList();
       }

        [WebMethod]
        public List<Get_Presence_Result> DONNEPRESENCEAVECIDCOURS(int P_Id)
        {
            return labase.Get_Presence(P_Id).ToList();
        }

        [WebMethod]
        public List<C_Utilisateurs> DonneUtilisateurs()
        {
            return labase.Get_All_USERS().ToList();
        }

        [WebMethod]
        public List<C_Utilisateurs> Add_User(string Nom, string Prenom)
        {
            labase.ADD_UTILISATEURS(Nom, Prenom);
            return labase.Get_All_USERS().ToList();
        }

        [WebMethod]
        public string AddPresence(int Id_User, int Id_Cours_Choisi)
        {
            labase.ADD_PRESENCE(Id_User, Id_Cours_Choisi);
            return "Presence ajoute";
        }

        [WebMethod]
        public string SupprimePresence()
        {
            labase.DELETE_ALL_PRESENCE();
            return ("Toutes les présences ont été suprimés");
        }

    }
}
