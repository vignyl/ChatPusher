using ChatPusher.Models;
using ChatPusher.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; 

namespace ChatPusher.Controllers
{
    public class AuthController : PusherController
    {
        private Model1 db = new Model1();
         
        public ActionResult Index()
        { 
            return View();
        }

        [HttpPost] 
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {

                User user = null;
                try
                {
                    user = db.User.FirstOrDefault(u => u.phone == model.phone && u.password == model.password);
                    if (user != null)
                    {

                        Session["user"] = user;
                        return Redirect("/chat");

                    }
                    ModelState.AddModelError("", "User not found");

                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", "User not found");
                    return View();
                }
            }
            return View();
        }

        public JsonResult AuthForChannel(string channel_name, string socket_id)
        {
            if (Session["user"] == null)
            {
                return Json(new { status = "error", message = "User is not logged in" });
            }
            var currentUser = (Models.User)Session["user"];
             

            if (channel_name.IndexOf(currentUser.id.ToString()) == -1)
            {
                return Json(
                  new { status = "error", message = "User cannot join channel" }
                );
            }

            var auth = pusher.Authenticate(channel_name, socket_id);

            return Json(auth);
        }
    }
}