using Microsoft.AspNetCore.Mvc;

namespace TWTodoList.Controllers;

public class TesteController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}