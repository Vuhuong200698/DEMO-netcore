using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace demoMVC.Controllers
{
    public class HelloWorldController : Controller
    {public IActionResult index(){
        return View();
    }
    public IActionResult demo(){
        return View();
    }

    }
}