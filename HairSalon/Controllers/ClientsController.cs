using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.Controllers
{
  public class ClientController : Controller
  {

    [HttpGet("/items")]
    public ActionResult Index()
    {
        List<Client> allClients = Client.GetAll();
        // return new EmptyResult(); //Test 1 will fail
        // return View(0); //Test 2 will fail
        return View(allClients);  //Test will pass
    }

    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      List<Stylist> listStylists = Stylist.GetAll();
      // return new EmptyResult(); //Test 1 will fail
      return View(0); //Test 2 will fail
      // return View(listStylists); //Test will pass
    }
    // [HttpPost("/items")]
    // public ActionResult Create()
    // {
    //   Client newClient = new Client (Request.Form["newClient"]);
    //   newClient.Save();
    //   List<Client> allClients = Client.GetAll();
    //   return View("Index", allClients);
    // }
    // [HttpGet("/items/{id}/update")]
    // public ActionResult UpdateForm(int id)
    // {
    //     Client thisClient = Client.Find(id);
    //     return View(thisClient);
    // }
    // [HttpPost("/items/{id}/update")]
    // public ActionResult Update(int id)
    // {
    //     Client thisClient = Client.Find(id);
    //     thisClient.Edit(Request.Form["newname"]);
    //     return RedirectToAction("Index");
    // }
    //
    // [HttpGet("/items/{id}/delete")]
    // public ActionResult Delete(int id)
    // {
    //     Client thisClient = Client.Find(id);
    //     thisClient.Delete();
    //     return RedirectToAction("Index");
    // }
    // [HttpPost("/items/delete")]
    // public ActionResult DeleteAll()
    // {
    //   Client.ClearAll();
    //   return View();
    // }
  }
}
