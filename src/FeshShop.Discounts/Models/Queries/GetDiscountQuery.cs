namespace FeshShop.Discounts.Models.Queries
{
    using FeshShop.Common.Mediator.Types;
    using FeshShop.Discounts.Models.Dto;
    using System;
    using System.Collections.Generic;

    public class GetDiscountQuery : IQuery<IEnumerable<GetDiscountDto>>
    {
        public Guid Id { get; set; }
    }
}
