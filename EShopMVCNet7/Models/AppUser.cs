using Microsoft.EntityFrameworkCore;
using EShopMVCNet7.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace EShopMVCNet7.Models
{
    //nạp vào giá trị ko trùng nhau
    [Index("Username",IsUnique = true)]
    [Index("Email",IsUnique = true)]
    public class AppUser
    {
        public int Id {get;set;}
        //ben duoi se cau hinh not null
        [Required(ErrorMessage ="Tên đăng nhập là bắt buộc")]
        //do dai ki tu
        [MaxLength(100)]
        [MinLength(4)]
        public string Username {get;set;}
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu !")]
        [MaxLength(200)]
        public string Password {get;set;}

        [NotMapped]
        [Compare("Password", ErrorMessage = "Mật khẩu không khớp !")]  //Ko tạo bảng Cfm_Password trong database
        [Required(ErrorMessage = "Vui lòng nhập lại mật khẩu !")]

        public string Cfm_Password {get;set;}
        public UserRole Role {get;set;} //Phần quyền khách và admin

        [MaxLength(20)]
        [Required(ErrorMessage = "Vui lòng nhập sdt !")]
        public string Phone {get;set;}
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ !")]
        [MaxLength(50)]
        public string Address {get;set;}
        [Required(ErrorMessage = "Vui lòng nhập mail  !")]
        [MaxLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email {get;set;}
        public DateTime? BlockedTo { get; set; }//Dùng cho chức năng khóa tài khoản
    }
}
    