using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dependency2.Models;
using dependency2.Repository;
using dependency2.Iinterface;

namespace dependency2.Controllers
{
    public class officerController : Controller
    {
        //
        // GET: /officer/
        officerContext oc = new officerContext();
        officerRepository or = new officerRepository();

        private IUnitOfWork _unitOfWork;
        private IOfficerService _offser;
        public officerController(IUnitOfWork unitOfWork,IOfficerService offser)
        {
            _unitOfWork = unitOfWork;
            _offser = offser;
        }
        public ActionResult Index(string search)
        {
            if (!string.IsNullOrEmpty(search))
            {
                return View(oc.officers.Where(x => x.name.StartsWith(search)).ToList());
            }
            else
            {
                List<officer> modelList = _unitOfWork.ModelRepository.Get();
                return View(modelList);
             //   return View(oc.officers.ToList());
            }
        }
    //    private IUnitOfWork _unitOfWork;
 
    //public HomeController(IUnitOfWork unitOfWork)
    //{
    //    _unitOfWork = unitOfWork;
    //}
 
    ////
    //// GET: /Home/
 
    //public ActionResult Index()
    //{
    //    // get all models
    //    List<Model> modelList = _unitOfWork.ModelRepository.Get(m => m.FirstName == "Jan" || m.LastName == "Holinka", includeProperties: "Account");
 
    //    // show list of models in view
    //    return View(modelList);
    //}
        //
        // GET: /officer/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /officer/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /officer/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                officer o = new officer();
                o.name = collection["name"];
                //oc.officers.Add(o);
                //oc.SaveChanges();
              //  or.Add(o);
                _offser.CreateOfficer(o);
                return RedirectToAction("Index");
            }
            else
            {
                return View(oc.officers.ToList());
            }
            
        }

        //
        // GET: /officer/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /officer/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                officer k = oc.officers.Find(id);
               
                UpdateModel(k);
                oc.SaveChanges();
 

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /officer/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                officer of = oc.officers.Find(id);
                or.Delete(of);
                //oc.officers.Remove(of);
                //oc.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
