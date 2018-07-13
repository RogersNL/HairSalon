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

    // [HttpGet("/categories/new")]
    // public ActionResult CreateForm()
    // {
    //     return View();
    // }
    // [HttpPost("/categories")]
    // public ActionResult Create()
    // {
    //   Stylist newStylist = new Stylist (Request.Form["newStylist"]);
    //   newStylist.Save();
    //   List<Stylist> allStylists = Stylist.GetAll();
    //   return View("Index", allStylists);
    // }
    // [HttpGet("/categories/{id}/update")]
    // public ActionResult UpdateForm(int id)
    // {
    //     Stylist thisStylist = Stylist.Find(id);
    //     return View(thisStylist);
    // }
    // [HttpPost("/categories/{id}/update")]
    // public ActionResult Update(int id)
    // {
    //     Stylist thisStylist = Stylist.Find(id);
    //     thisStylist.Edit(Request.Form["newname"]);
    //     return RedirectToAction("Index");
    // }
    //
    // [HttpGet("/categories/{id}/delete")]
    // public ActionResult Delete(int id)
    // {
    //     Stylist thisStylist = Stylist.Find(id);
    //     thisStylist.Delete();
    //     return RedirectToAction("Index");
    // }
    // [HttpPost("/categories/delete")]
    // public ActionResult DeleteAll()
    // {
    //   Stylist.ClearAll();
    //   return View();
    // }
    // [HttpGet("/categories/{id}")]
    // public ActionResult Details(int id)
    // {
    //     Stylist item = Stylist.Find(id);
    //     return View(item);
    // }
  }
}
