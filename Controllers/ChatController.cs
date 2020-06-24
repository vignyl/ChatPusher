using ChatPusher.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PusherServer;

namespace ChatPusher.Controllers
{
    public class ChatController : PusherController
    {
        private Model1 db = new Model1();

        public ActionResult Index()
        {
            if (Session["user"] == null) return Redirect("/Auth");

            var currentUser = (User) Session["user"]; 

            ViewBag.allUsers = db.User.Where(u => u.name != currentUser.name).ToList();  
            ViewBag.currentUser = currentUser; 
            return View();
        }

        public JsonResult ConversationWithContact(int contact)
        {
            if (Session["user"] == null)
            {
                return Json(new { result_code = -1, message = "User is not logged in" });
            }

            var currentUser = (Models.User)Session["user"];

            var conversations = new List<Models.Conversation>(); 
            conversations = db.Conversation.
                                Where(c => (c.receiver_id == currentUser.id
                                    && c.sender_id == contact) ||
                                    (c.receiver_id == contact
                                    && c.sender_id == currentUser.id))
                                .OrderBy(c => c.created)
                                .ToList(); 

            return Json(
                new { 
                    result_code = 1,
                    data = conversations 
                },
                JsonRequestBehavior.AllowGet
            );
        }

        [HttpPost]
        public JsonResult SendMessage()
        {
            if (Session["user"] == null)
            {
                return Json(new { status = "error", message = "User is not logged in" });
            }

            var currentUser = (User)Session["user"];

            string socket_id = Request.Form["socket_id"];

            int contactId = Convert.ToInt32(Request.Form["contact"]);

            Conversation convo = new Conversation
            {
                sender_id = currentUser.id,
                message = Request.Form["message"],
                receiver_id = contactId
            }; 

            db.Conversation.Add(convo);
            db.SaveChanges();

            var conversationChannel = getConvoChannel(currentUser.id, contactId);

            pusher.TriggerAsync(
              conversationChannel,
              "new_message",
              convo,
              new TriggerOptions() { SocketId = socket_id });

            return Json(convo);
        }

        private String getConvoChannel(Decimal user_id, int contact_id)
        {
            if (user_id > contact_id)
            {
                return "private-chat-" + contact_id + "-" + user_id;
            }

            return "private-chat-" + user_id + "-" + contact_id;
        }
    }
}