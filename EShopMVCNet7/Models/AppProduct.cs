namespace EShopMVCNet7.Models
{
    public class AppProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }//Làm đẹp
        public string Summary { get; set; }//Mô tả ngắn
        public string Content { get; set; }//Mô tả đầy đủ
        public string CoverImg { get; set; }//Ảnh hiện ở trang danh sách
        public int InStock { get; set; }//Tồn kho
        public double Price { get; set; }//Gía
        public double? DiscountPrice { get; set; }//Gía giảm
        public DateTime? DiscountFrom { get; set; }//Hết thời gian giảm giá lấy về giá gốc (Gía khuyến mãi)
        public DateTime? DiscountTo { get; set; }
        public int? View { get; set; }//Lượt xem
        public int? CategoryId { get; set; }//Khóa ngoại ,danh mục sản phẩm
        public int? CreatedBy { get; set; }//User thêm sản phẩm, khóa ngoại
        public DateTime? CreatedAdd { get; set; }//Thời điểm tạo sản phẩm
    }
}
