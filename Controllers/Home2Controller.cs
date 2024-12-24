using Microsoft.AspNetCore.Mvc;

namespace Echo_Merch.Controllers
{
    public class Home2Controller : Controller
    {
        public string Index(int id)
        {
            return "home2 return = " + id;
        }
    }
}
