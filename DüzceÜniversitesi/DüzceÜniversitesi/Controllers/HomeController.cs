using DüzceÜniversitesi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DüzceÜniversitesi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() //ana sayfa
        {
            return View();
        }

        public IActionResult Academic() //fakültelerin bulunduğu sayfa
        {
            return View();
        }

        public IActionResult Gallery() //galeri sayfası
        {
            return View();
        }

        public IActionResult Communication() //iletişim sayfası
        {
            return View();
        }

        public IActionResult Communication2() //detaylı iletişim sayfası
        {
            return View();
        }

        public IActionResult About() //hakkında sayfası
        {
            return View();
        }

        [Authorize]
        public IActionResult Publis() //adminin konrolünde olan sayfa
        {
            return View();
        }

        Context c = new Context();

        [HttpGet]
        public ViewResult Login() //giriş yapma sayfası
        {
            return View();
        }
        [HttpPost]
        public ViewResult Login(User user) //giriş yapma sayfası
        {
            var adminUser = c.users.FirstOrDefault(x => x.email == user.email && x.sifre == user.sifre);
            if (ModelState.IsValid && adminUser!=null)
            {
                var degerler = c.announcements.ToList();
                return View("Publis", degerler);
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Post() //duyuru paylaşma sayfası
        {
            return View();
        }
        [HttpPost]
        public IActionResult Post(Announcement A) //duyuru paylaşma sayfası
        {
            c.announcements.Add(A);
            c.SaveChanges();
            var degerler = c.announcements.ToList();
            return View("Publis", degerler);
        }

        public IActionResult Announcements() //duyurular sayfası
        {
            var degerler = c.announcements.ToList();
            return View(degerler);
        }

        public IActionResult DeleteAnnouncement(int ID) //duyuru sil
        {
            var announ = c.announcements.Find(ID);
            c.announcements.Remove(announ);
            c.SaveChanges();
            var degerler = c.announcements.ToList();
            return View("Publis", degerler);
        }

        public IActionResult ComeAnnouncement(int ID) //duyuru güncellemek için gidilen sayfa
        {
            var anno = c.announcements.Find(ID);
            var degerler = c.announcements.ToList();
            return View("ComeAnnouncement", anno);
        }

        public IActionResult UpdateAnnouncement(Announcement A) //duyuruyu güncelleme
        {
            var announ = c.announcements.Find(A.ID);
            announ.DuyuruBasligi = A.DuyuruBasligi;
            announ.DuyuruIcerigi = A.DuyuruIcerigi;
            c.SaveChanges();
            var degerler = c.announcements.ToList();
            return View("Publis", degerler);
        }

        public IActionResult Detail(Announcement A) //detaylar sayfası
        {
            var announ = c.announcements.Find(A.ID);
            var degerler = c.announcements.ToList();
            return View("Detail", announ);
        }

        public IActionResult Empty() //boş sayfalar için
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
