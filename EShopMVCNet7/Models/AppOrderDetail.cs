namespace EShopMVCNet7.Models
{
    public class AppOrderDetail
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }//Lưu khóa ngoại
        public string ProductName { get; set; }
        public double? Price { get; set; }//Gía sản phẩm tại điểm mua hàng
        public int? Quantity { get; set; }

    }
}