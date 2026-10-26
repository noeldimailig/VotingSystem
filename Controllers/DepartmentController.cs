using Microsoft.AspNetCore.Mvc;

namespace VotingSystem.Controllers;

public class DepartmentController : Controller
{
    public IActionResult Index() => View();
    
    public IActionResult Create() => View();
    
    public IActionResult Update() => View();
    
    public IActionResult Delete() => View();
}