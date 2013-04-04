using System.Web.Mvc;
using ModelValidation.Models;

namespace ModelValidation.Controllers
{
    public class RegistrationController : Controller
    {
        public IRegistrationRepositary RegisterRepo { get; set; }

        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            if (RegisterRepo == null)
            {
                RegisterRepo = new RegistrationRepositary();
            }
            base.Initialize(requestContext);
        } 

        //
        // GET: /Registration/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Registration/Create

        [HttpPost]
        public ActionResult Create(Registration reg)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RegisterRepo.Register(reg);
                }
                else
                {
                    return View();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
