using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp4.Models;
using tp4.Data;

namespace tp4.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        
    }

    public IActionResult Index()
    {   var context =UniversityContext.universitycontextinstance;
        Debug.WriteLine("done");
        List<Student> s = context.Student.ToList();
        foreach (var item in s)
        {
           Debug.WriteLine(item.first_name);
        }
        return View();
    }

    public IActionResult Privacy()
    {   var context2 =UniversityContext.universitycontextinstance;
        Debug.WriteLine("done");
        return View();
    }
    [Route("/Home/Course")]
    public IActionResult course()
    {   var repository=new StudentRepository();
        List <string> courses =repository.GetAllCourses().ToList();
        
        return View(courses);
    }
    [Route("/Home/Course/{course?}")]
     public IActionResult studentbycourse(string course)
    {   var repository=new StudentRepository();
        List <string> courses =repository.GetAllCourses().ToList();
        List <Student> students=new List<Student>() ;
        if(courses.IndexOf(course)==-1){
            ViewData["Title"]="\"" + course + "\" is not a course !!!";
            return View(students);
        }
        students=repository.StudentsByCourse(course).ToList();
        ViewData["Title"]=course +" : list of enrolled students";

        return View(students);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
