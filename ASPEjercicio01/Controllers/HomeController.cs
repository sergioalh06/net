using ASPEjercicio01.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCFEjercicio01;
using WCFEjercicio01.Model;

namespace ASPEjercicio01.Controllers
{
    public class HomeController : Controller
    {
        Service s = new Service();

        public ActionResult Index(Output1 output1 = null)
        {
            return View(output1);
        }


        public ActionResult Edit(string dni)
        {
            var a = s.getByDNI(dni);
            return View(a);
        }

        [HttpPost]
        public ActionResult Edit(Person p)
        {
            var a = s.updateByDNI(p);
            return RedirectToAction("Edit",new { dni = p.DNI } );
        }

        public ActionResult Consumir(String dni)
        {
            var a = s.getByDNI(dni);
            Input1 tmp = new Input1();
            tmp.age = a.Age.ToString();
            tmp.capitalgain = a.Capital_gain.ToString();
            tmp.capitaloss = a.Capital_loss.ToString();
            tmp.education = a.Education.ToString();
            tmp.educationum = a.Education_num.ToString();
            tmp.fnlwgt = a.Fnlwgt.ToString();
            tmp.hoursperweek = a.Hours_per_week.ToString();
            tmp.maritalstatus = a.Relationship.ToString();
            tmp.nativecountry = a.Id_Country.ToString();
            tmp.occupation = a.Occupation.ToString();
            tmp.race = a.Race.ToString();
            tmp.relationship = a.Relationship.ToString();
            tmp.sex = a.Id_Sex.ToString();
            tmp.workclass = a.Workclass.ToString();

            var inputdatatmp = new InputDataMLS(tmp);

            Output1 output1 = new PredictML().ConsumeMLS(inputdatatmp).Result;


            return RedirectToAction("Index", output1);
            //return View();
        }
    }
}