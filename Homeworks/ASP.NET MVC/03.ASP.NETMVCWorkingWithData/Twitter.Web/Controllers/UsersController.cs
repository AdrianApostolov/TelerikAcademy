using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNet.Identity;
using Twitter.Data.Repositories;
using Twitter.Models;
using Twitter.Web.ViewModels;

namespace Twitter.Web.Controllers
{
    public class UsersController : Controller
    {
        public IRepository<User> users;

        public IRepository<Tweet> tweets; 

        public UsersController(IRepository<User> users, IRepository<Tweet> tweets)
        {
            this.users = users;
            this.tweets = tweets;
        }

        // GET: Users
        public ActionResult Index()
        {
            return View(this.users.All().ProjectTo<UserViewModel>());
        }

        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var tweets = this.tweets.All().Where(x => x.User.Id == id).ProjectTo<TweetViewModel>();
            var user = this.users.GetById(id);
            ViewBag.CurrentUser = user.UserName;
            if (tweets == null)
            {
                return HttpNotFound();
            }

            return View(tweets);
        }
    }
}