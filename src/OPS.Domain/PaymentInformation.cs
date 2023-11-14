using OPS.Domain.Common;

namespace OPS.Domain
{
    public class PaymentInformation : BaseEntity
    {
        public int OwnerId { get; set; } // ID của người sở hữu (User/Customer)
        public string PaymentMethod { get; set; } // Phương thức thanh toán
        public string CardNumber { get; set; } // Số thẻ
        public string ExpiryDate { get; set; } // Ngày hết hạn
        public string CVV { get; set; } // Mã bảo mật (CVV/CVC)
        public string CardHolderName { get; set; } // Tên chủ thẻ
        public string CardType { get; set; } // Loại thẻ
    }
}