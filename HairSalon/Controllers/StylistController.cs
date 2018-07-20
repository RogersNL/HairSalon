using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.Controllers
{
  public class StylistController : Controller
  {

    [HttpGet("/stylists")]
    public ActionResult Index()
    {
        List<Stylist> allStylists = Stylist.GetAll();
        // return new EmptyResult(); //Test 1 will fail
        // return View(0); //Test 2 will fail
        return View(allStylists);  //Test will pass
    }

    [HttpGet("/stylists/new")]
    public ActionResult CreateForm()
    {
      // return new EmptyResult(); //Test will fail
      return View(); //Test will pass
    }

    [HttpPost("/stylists")]
    public ActionResult Create()
    {
      Stylist newStylist = new Stylist (Request.Form["newStylist"]);
      newStylist.Save();
      List<Stylist> allStylists = Stylist.GetAll();
      return View("Index", allStylists);
    }
    [HttpGet("/stylists/{id}/update")]
    public ActionResult UpdateForm(int id)
    {
        Stylist thisStylist = Stylist.Find(id);
        return View(thisStylist);
    }
    [HttpPost("/stylists/{id}/update")]
    public ActionResult Update(int id)
    {
        Stylist thisStylist = Stylist.Find(id);
        thisStylist.Edit(Request.Form["updateStylist"]);
        return RedirectToAction("Index");
    }

    [HttpGet("/stylists/{id}/delete")]
    public ActionResult Delete(int id)
    {
        Stylist thisStylist = Stylist.Find(id);
        thisStylist.Delete();
        return RedirectToAction("Index");
    }
    [HttpPost("/stylists/{stylistId}/specialties/new")]
    public ActionResult AddSpecialty(int stylistId)
    {
      Stylist stylist = Stylist.Find(stylistId);
      Specialty specialty = Specialty.Find(int.Parse(Request.Form["specialtyid"]));
      stylist.AddSpecialty(specialty);
      return RedirectToAction("Details",  new { id = stylistId });
    }
    [HttpGet("/stylists/{id}")]
    public ActionResult Details(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Stylist selectedStylist = Stylist.Find(id);
      List<Client> selectedClients = Client.GetClientsById(id);
      List<Specialty> selectedSpecialties = selectedStylist.GetSpecialties();
      List<Specialty> allSpecialties = Specialty.GetAll();
      List<Client> allClients = Client.GetAll();
      model.Add("allClients", allClients);
      model.Add("allSpecialties", allSpecialties);
      model.Add("selectedSpecialties", selectedSpecialties);
      model.Add("selectedClients", selectedClients);
      model.Add("selectedStylist", selectedStylist);
      // return new EmptyResult(); //Test 1 will fail
      // return View(0); //Test 2 will fail
      return View(model); //Test will pass
    }
  }
}
