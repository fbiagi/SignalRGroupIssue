using System;
using System.Web.Mvc;
using Microsoft.AspNet.SignalR;

namespace SignalRGroupIssue.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public string Send(string group, string message)
        {
            GlobalHost.ConnectionManager.GetConnectionContext<RtConnection>()
                .Groups.Send(group, message);
            return string.Format("Sent {0} to group {1} at {2}", message, group,
                DateTime.Now.ToLongTimeString());
        }
    }
}
