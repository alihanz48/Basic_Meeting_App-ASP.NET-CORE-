using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;

namespace MeetingApp.Controllers{
    public class HomeController:Controller{

        public IActionResult Index(){
            int saat=DateTime.Now.Hour;

            //ViewBag.selamlama=(saat>12?"İyi Günler":"Günaydın");
            //ViewBag.username="Alihan";
            
            ViewData["selamlama"]= saat > 12 ? "İyi Günler":"Günaydın";
            int userCount=Repository.Users.Where(user=>user.willattend==true).Count();
            
            var meetinginfo=new MeetingInfo(){
                id=1,
                location="İstanbul,Abc kongre merkezi",
                Date=new DateTime(2024,01,20),
                NumberOfPeople=userCount,
            };

            return View(meetinginfo);
        }
    }
}