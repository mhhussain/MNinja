using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace MNinja.App.Controllers
{
    public class MainController : ApiController
    {
        [HttpGet]
        public virtual HttpResponseMessage Run()
        {
            var template = new StringBuilder(File.ReadAllText(HttpContext.Current.Server.MapPath(@"~/index.html")));

            var response = new HttpResponseMessage();
            response.Content = new StringContent(template.ToString(), Encoding.UTF8, "text/html");

            return response;
        }
    }
}
