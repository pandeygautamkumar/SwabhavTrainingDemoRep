
using System;
using System.Web.Http;

namespace SimpleWebApiApp.Controllers
{
    public class WelcomeController : ApiController
    {
        public WelcomeController()
        {
        }
        public string Get()
        {
            return "Get Called";
        }
        public string Post()
        {
            return "Post Called";
        }
        public string Put()
        {
            return "Put Called";
        }
        public string Delete()
        {
            return "Delete Called";
        }
    }
}
