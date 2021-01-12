using LMSFinalProject.UI.MVC.Models;
using System;
using System.Net;
using System.Net.Mail;
using System.Web.Mvc;

namespace LMSFinalProject.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Index(ContactModel cvm)
        {
            if (ModelState.IsValid)
            {
                string body = $"{cvm.Name} has sent you the following message:</br>" +
                    $"{cvm.Message} <strong>From the email address of: </strong>{cvm.Email}";

                MailMessage m = new MailMessage("Education@Connection.com", "kjohnw2002@gmail.com", cvm.Subject, body);

                m.IsBodyHtml = true;
                m.Priority = MailPriority.High;
                m.ReplyToList.Add(cvm.Email);

                SmtpClient client = new SmtpClient("mail.EducationConnection.com.ext");
                client.Credentials = new NetworkCredential("kjohnw2002@gmail.com", "Kjw2002!");
                client.Port = 8889;
                try
                {
                    client.Send(m);
                }
                catch (Exception e)
                {
                    ViewBag.Message = e.StackTrace;

                }
                return View("EmailConfirmation",cvm);
            }
            return View(cvm);
        }
    }
}
