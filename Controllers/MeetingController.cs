using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {

        [HttpGet]
        public IActionResult Apply(){
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model){
            if(ModelState.IsValid){
              Repository.CreateUser(model);
              ViewBag.usercount=Repository.Users.Where(userwa=>userwa.willattend==true).Count();
              return View("Thanks",model);
            }else{
                return View(model);
            }
            
        }

        [HttpGet]
        public IActionResult List(){
            return View(Repository.Users);
        }

        [HttpGet]
        public IActionResult Details(int id){
            var userInfo=Repository.userDetails(id);
            return View(userInfo);
        }
    }
}