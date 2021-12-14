using JobBoard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace JobBoard.Controllers
{
  public class OpeningsController : Controller
  {
    [HttpGet("/openings")]
    public ActionResult Index()
    {
      return View(JobOpening.Jobs);
    }

    [HttpGet("/addjob")]
    public ActionResult AddJobForm()
    {
      return View();
    }

    [HttpPost("/addjob")]
    public ActionResult AddJob(IFormCollection input)
    {
      JobOpening newJob = new JobOpening(input["title"], input["description"], input["name"], input["email"], input["phone"]);
      return RedirectToAction("Index", JobOpening.Jobs);
    }
  }
}