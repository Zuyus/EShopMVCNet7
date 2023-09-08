using EShopMVCNet7.Models;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace EShopMVCNet7.Areas.Admin.Controllers
{
    //Kế thừa Ctroller
    
    public class UserController : AdminBaseController
    {
        //Thằng Cha
        public UserController(EShopDbContext db) : base(db)
        {
            
        }
        //Phân trang thêm OrderBy
        public IActionResult Index(int page = 1)

        {
            var data = _db.AppUsers
                .OrderByDescending(x => x.Id)
                .ToPagedList(page, PER_PAGE); //Viết const phải viết Hoa hết. 
            return View(data); //chuyển data qua view
        }

        //Update:
        //Một trang chỉ có 1 model
        public IActionResult Update(int id) 
        {
            var data = _db.AppUsers.Find(id);
            if (data == null) 
            {
                return RedirectToAction(nameof(Index));
            }
            return View(data);
        }
    }
}
