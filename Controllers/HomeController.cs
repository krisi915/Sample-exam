using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Sample_exam.ViewModels.Reservations;
using Sample_exam.DataAccess;
using Sample_exam.Entities;

namespace Sample_exam.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index(IndexVM Model)
        {
            ReservationsRepository repo = new ReservationsRepository();
            Model.Items = repo.GetAll();

            return View(Model);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateVM Model) 
        {
            ReservationsRepository repo = new ReservationsRepository();
            int ItemsCount = repo.GetAll(r => r.DateTime == Model.DateTime).Count;

            if (ItemsCount >= 10)
            {
                ModelState.AddModelError("TooMany", "*Sorry, there are no free tables for this day!");
                return View(Model);
            }

            Reservation Item = new Reservation();
            Item.FullName = Model.FullName;
            Item.TableSize = Model.TableSize;
            Item.DateTime = Model.DateTime;
    
            
            repo.Insert(Item);

            return RedirectToAction("Index", "Home");
            
        }

       [HttpGet]
        public IActionResult Edit(int Id)
        {
            ReservationsRepository repo = new ReservationsRepository();
            Reservation Item = repo.GetById(Id);
            if (Item == null)
            {
                return RedirectToAction("Index", "Home");
            }

            EditVM model = new EditVM();
            model.Id = Item.Id;
            model.FullName = Item.FullName;
            model.TableSize = Item.TableSize;
            model.DateTime = Item.DateTime.ToString("dd.MM.yyyy");

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            ReservationsRepository repo = new ReservationsRepository();
            DateTime input = DateTime.Parse(model.DateTime);
            int ItemsCount = repo.GetAll(r => r.DateTime == input).Count;

            if (ItemsCount >= 10)
            {
                ModelState.AddModelError("TooMany", "*Sorry, there are no free tables for this day!");
                return View(model);
            }

            Reservation Item = new Reservation();
            Item.Id = model.Id;
            Item.FullName = model.FullName;
            Item.TableSize = model.TableSize;
            Item.DateTime = input;

            repo.Update(Item);

            return RedirectToAction("Index", "Home");

        }

        public IActionResult Delete(int Id)
        {
            ReservationsRepository repo = new ReservationsRepository();
            Reservation Item = new Reservation();
            Item.Id = Id;

            repo.Delete(Item);

            return RedirectToAction("Index", "Home");

        }

    }
}

