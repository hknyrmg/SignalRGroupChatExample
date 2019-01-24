using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SignalRChat.viewModel;
using SignalRChat.Models;
using System.Diagnostics;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System.Text;

namespace SignalRChat.Controllers
{
    public class HomeController : Controller
    {
        private IDistributedCache _distributedCache;

        public HomeController(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View("GetGroupName");
        }
        [HttpPost]
        public IActionResult Index(GroupUser s)
        {
            ViewBag.userName = s.userName;
            //return View("Index", s);
            return View("../Default/Formal", s);

        }

    }
}