﻿using Microsoft.AspNetCore.Mvc;
using TPLOCAL1.Models;
using System;
using System.Text.RegularExpressions;
using System.Linq.Expressions;


//Subject is find at the root of the project and the logo in the wwwroot/ressources folders of the solution
//--------------------------------------------------------------------------------------
//Careful, the MVC model is a so-called convention model instead of configuration,
//The controller must imperatively be name with "Controller" at the end !!!
namespace TPLOCAL1.Controllers
{
    public class HomeController : Controller
    {
        //method "naturally" call by router
        public ActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                //retourn to the Index view (see routing in Program.cs)
                return View();
            else
            {
                //Call different pages, according to the id pass as parameter
                switch (id)
                {
                    case "AvisList":
                        //TODO : code reading of the xml files provide
                        List<Opinion> opinionList = new OpinionList().GetAvis("XmlFiles/DataAvis.xml");
                        ViewBag.opinionList = opinionList;
                        return View(id);
                    case "Form":
                        //TODO : call the Form view with data model empty
                        return View(id);
                    case "Validation":
                        return View(id);
                    default:
                        //return to the Index view (see routing in Program.cs)
                        return View();
                }
            }
        }


        [HttpPost]
        public ActionResult Validation(Formulaire formulaire)
        {
            bool b = ModelState.IsValid;
            if (ModelState.IsValid)
            {
                formulaire.DateDebut = formatageDate(formulaire.DateDebut);
                return View("Validation", formulaire);

            }
            else
            {
                return View("Form", formulaire);
            }
        }

        // Transformation d'une date sous la forme AAAA-MM-JJ en une date sur la forme JJ/MM/AAAA
        public String formatageDate(String date)
        {
            return date.Substring(8, 2) + "\\" + date.Substring(5, 2) + "\\" + date.Substring(0, 4);
        }
    }
}