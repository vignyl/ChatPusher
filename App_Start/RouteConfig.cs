﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ChatPusher
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "Login",
                url: "login",
                defaults: new { controller = "Auth", action = "Index" }
            );

            routes.MapRoute(
                name: "Login_post",
                url: "login_post",
                defaults: new { controller = "Auth", action = "Login" }
            );

            routes.MapRoute(
                name: "ChatRoom",
                url: "chat",
                defaults: new { controller = "Chat", action = "Index" }
            );

            routes.MapRoute(
                name: "SendMessage",
                url: "send_message",
                defaults: new { controller = "Chat", action = "SendMessage" }
            );

            routes.MapRoute(
                name: "PusherAuth",
                url: "pusher/auth",
                defaults: new { controller = "Auth", action = "AuthForChannel" }
            );
        }
    }
}
