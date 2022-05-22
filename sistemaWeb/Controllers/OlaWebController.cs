using System.Web;
using System.Web.Mvc;

namespace sistemaWeb.Controllers
{
    public class OlaWebController : Controller
    {
        // GET: OlaWeb
        public string Index()
        {
            return "Sistema de cadastro para Web";
        }   

          //  
            // GET: /OlaWeb/Bem vindo a Web;

        public string Sistema(string name, int numTimes = 1) { 
            return HttpUtility.HtmlEncode( "Olá" + name + ", NumTimes is:"+ numTimes);
        }
    }
}