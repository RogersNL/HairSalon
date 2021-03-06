using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.Controllers
{
  public class ClientController : Controller
  {

    [HttpGet("/clients")]
    public ActionResult Index()
    {
      List<Client> allClients = Client.GetAll();
      // return new EmptyResult(); //Test 1 will fail
      // return View(0); //Test 2 will fail
      return View(allClients);  //Test will pass
    }
    [HttpGet("/clients/prevent")]
    public ActionResult PreventSubmit()
    {
      // return new EmptyResult(); //Test 1 will fail
      // return View(0); //Test 2 will fail
      return View();  //Test will pass
    }
    [HttpGet("/clients/new")]
    public ActionResult CreateForm()
    {
      List<Stylist> listStylists = Stylist.GetAll();
      if(listStylists.Count > 0)
      {
        // return new EmptyResult(); //Test 1 will fail
        // return View(0); //Test 2 will fail
        return View(listStylists); //Test will pass
      }
      else
      {
        return RedirectToAction("PreventSubmit");
      }

    }
    [HttpPost("/clients")]
    public ActionResult Create()
    {
      Client newClient = new Client (Request.Form["newClient"], int.Parse(Request.Form["stylistId"]));
      newClient.Save();
      List<Client> allClients = Client.GetAll();
      return View("Index", allClients);
    }
    [HttpGet("/clients/{id}/update")]
    public ActionResult UpdateForm(int id)
    {
        Client thisClient = Client.Find(id);
        return View(thisClient);
    }
    [HttpPost("/clients/{id}/update")]
    public ActionResult Update(int id)
    {
        Client thisClient = Client.Find(id);
        thisClient.Edit(Request.Form["updateClient"]);
        return RedirectToAction("Index");
    }

    [HttpGet("/clients/{id}/delete")]
    public ActionResult Delete(int id)
    {
        Client thisClient = Client.Find(id);
        thisClient.Delete();
        return RedirectToAction("Index");
    }
  }
}
