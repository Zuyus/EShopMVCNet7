using EShopMVCNet7.Models;
using Microsoft.AspNetCore.Mvc;

namespace EShopMVCNet7.Areas.Admin.Controllers
{
    //Thằng Con
    public class AdminBaseController : Controller
    {

        protected const int PER_PAGE = 20;

        protected EShopDbContext _db;

        public AdminBaseController(EShopDbContext db) 
        {
            _db = db;
        }

        //Update:


    }
}
