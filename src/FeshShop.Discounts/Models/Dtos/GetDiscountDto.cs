namespace FeshShop.Discounts.Models.Dto
{
    using System;

    public class GetDiscountDto
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }

        public string Code { get; set; }

        public short Percentage { get; set; }

        public bool Availiable { get; set; }
    }
}
