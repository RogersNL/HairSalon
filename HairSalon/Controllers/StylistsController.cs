using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.Controllers
{
  public class StylistController : Controller
  {

    [HttpGet("/categories")]
    public ActionResult Index()
    {
        List<Stylist> allStylists = Stylist.GetAll();
        // return new EmptyResult(); //Test 1 will fail
        // return View(0); //Test 2 will fail
        return View(allStylists);  //Test will pass
    }

    [HttpGet("/categories/new")]
    public ActionResult CreateForm()
    {
      // return new EmptyResult(); //Test will fail
      return View(); //Test will pass
    }

    [HttpPost("/categories")]
    public ActionResult Create()
    {
      Stylist newStylist = new Stylist (Request.Form["newStylist"]);
      newStylist.Save();
      List<Stylist> allStylists = Stylist.GetAll();
      return View("Index", allStylists);
    }
    [HttpGet("/categories/{id}/update")]
    public ActionResult UpdateForm(int id)
    {
        Stylist thisStylist = Stylist.Find(id);
        return View(thisStylist);
    }
    [HttpPost("/categories/{id}/update")]
    public ActionResult Update(int id)
    {
        Stylist thisStylist = Stylist.Find(id);
        thisStylist.Edit(Request.Form["updateStylist"]);
        return RedirectToAction("Index");
    }

    [HttpGet("/categories/{id}/delete")]
    public ActionResult Delete(int id)
    {
        Stylist thisStylist = Stylist.Find(id);
        thisStylist.Delete();
        return RedirectToAction("Index");
    }

    [HttpGet("/categories/{id}")]
    public ActionResult Details(int id)
    {
      List<Client> selectedClients = Client.GetClientsById(id);

      // return new EmptyResult(); //Test 1 will fail
      // return View(0); //Test 2 will fail
      return View(selectedClients); //Test will pass
    }
  }
}
