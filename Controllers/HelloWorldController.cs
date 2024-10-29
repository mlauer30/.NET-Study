using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    // public string Index()
    // {
    //     return "This is my default action...";
    // }
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    // public string Welcome(String name, int numTimes = 1)
    // {
    //     // return "This is the Welcome action method...";
    //     // https://localhost:7061/HelloWorld/Welcome?name=Rick&numTimes=5
    //     return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");

    // }
    // public string Welcome(String name, int ID = 1)
    // {
    //     // return "This is the Welcome action method...";
    //     // https://localhost:7061/HelloWorld/Welcome/3?name=Rick
    //     return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");

    // }

    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}