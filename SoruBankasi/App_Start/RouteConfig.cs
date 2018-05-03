﻿using System.Web.Mvc;
using System.Web.Routing;

namespace SoruBankasi
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(name: "Home", url: "", defaults: new { controller = "Home", action = "Index" });
            routes.MapRoute(name: "Login", url: "GirisYap", defaults: new { controller = "Account", action = "Login" });
            routes.MapRoute(name: "Logout", url: "CiksiYap", defaults: new { controller = "Account", action = "Logout" });

            #region Account
            routes.MapRoute(name: "ProfileDetail", url: "Profil", defaults: new { controller = "Account", action = "ProfileDetail" });
            routes.MapRoute(name: "ChangeMail", url: "ChangeMail", defaults: new { controller = "Account", action = "ChangeMail" });
            routes.MapRoute(name: "ChangePhoto", url: "ChangePhoto", defaults: new { controller = "Account", action = "ChangePhoto" });
            routes.MapRoute(name: "ChangePassword", url: "ChangePassword", defaults: new { controller = "Account", action = "ChangePassword" });
            #endregion

            #region Lessons
            routes.MapRoute(name: "Lessons", url: "Dersler", defaults: new { controller = "Lesson", action = "Index" });
            routes.MapRoute(name: "AddLesson", url: "DersEkle", defaults: new { controller = "Lesson", action = "Add" });
            routes.MapRoute(name: "EditLesson", url: "DersDuzenle/{ID}", defaults: new { controller = "Lesson", action = "Edit" });
            routes.MapRoute(name: "DeleteLesson", url: "DersSil", defaults: new { controller = "Lesson", action = "Delete" });
            #endregion

            #region Users
            routes.MapRoute(name: "Users", url: "Kullanicilar", defaults: new { controller = "Users", action = "Index" });
            routes.MapRoute(name: "AddUser", url: "KullaniciEkle", defaults: new { controller = "Users", action = "Add" });
            routes.MapRoute(name: "EditUser", url: "KullaniciDuzenle/{ID}", defaults: new { controller = "Users", action = "Edit" });
            routes.MapRoute(name: "DeleteUser", url: "KullaniciSil", defaults: new { controller = "Users", action = "Delete" });
            #endregion

            #region Topic
            routes.MapRoute(name: "Topics", url: "Konular", defaults: new { controller = "Topic", action = "Index" });
            routes.MapRoute(name: "AddTopic", url: "KonuEkle", defaults: new { controller = "Topic", action = "Add" });
            //routes.MapRoute(name: "EditTopic", url: "KonuDuzenle/{ID}", defaults: new { controller = "Topic", action = "Edit" });
            routes.MapRoute(name: "DeleteTopic", url: "KonuSil", defaults: new { controller = "Topic", action = "Delete" });
            #endregion

        }
    }
}
