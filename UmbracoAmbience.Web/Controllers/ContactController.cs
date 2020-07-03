using System.Web.Mvc;
using Umbraco.Web.Mvc;
using UmbracoAmbience.Web.Models;

namespace UmbracoAmbience.Web.Controllers
{
    public class ContactController : SurfaceController
    {
        public string GetPathView(string name)
        {
            return $"/Views/Partals/Content/{name}.cshtml";
        }

        [HttpGet]
        public ActionResult RenderForm()
        {
            ContactViewModel model = new ContactViewModel();
            return PartialView(GetPathView("_ContactForm"), model);
        }

        [HttpPost]
        public ActionResult RenderForm(ContactViewModel model)
        {
            return PartialView(GetPathView("_ContactForm"), model);
        }

        [HttpPost]
        public ActionResult SubmitForm(ContactViewModel model)
        {
            bool success = false;
            if (ModelState.IsValid)
            {
                success = SendEmail(model);
            }
            return PartialView(GetPathView(success ? "_Success" : "_Error"));   
        }

        public bool SendEmail(ContactViewModel model)
        {
            //GetHashCode for sending an email
            return true;
        }
    }
}