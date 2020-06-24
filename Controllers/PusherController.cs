using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PusherServer;

namespace ChatPusher.Controllers
{
    public class PusherController : Controller
    {
        protected PusherOptions options;
        protected Pusher pusher;
        //class constructor
        public PusherController()
        {
            options = new PusherOptions();
            options.Cluster = "eu";
            options.Encrypted = true;

            pusher = new Pusher(
                "996928",
                "54c1884d3f4ce877b1e5",
                "fee361db1c98a70955d3",
                options
            );
        }
    }
}