using System.Net.Mail;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using UmbracoAmbience.Web.Models;
using log4net;
using System.Reflection;

namespace UmbracoAmbience.Web.Controllers
{
    public class ContactController : SurfaceController
    {
        public string GetPathView(string name)
        {
            return $"/Views/Partals/Contact/{name}.cshtml";
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
            //set upt the log for catch
            ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            try
            {
                //GetHashCode for sending an email
                MailMessage message = new MailMessage();
                SmtpClient client = new SmtpClient();
                string toAddress = System.Web.Configuration.WebConfigurationManager.AppSettings["ContactEmailTo"];
                string fromAddress = System.Web.Configuration.WebConfigurationManager.AppSettings["ContactEmailFrom"];

                message.Subject = $"Enquiry from {model.Name} - {model.Email}";
                message.Body = model.Message;

                message.To.Add(new MailAddress(toAddress, toAddress));
                message.From = new MailAddress(fromAddress, fromAddress);

                client.Send(message);
                return true;
            }
            catch (System.Exception ex)
            {
                Log.Error("Contact Form Error", ex);
                return false;
            }
        }
    }
}