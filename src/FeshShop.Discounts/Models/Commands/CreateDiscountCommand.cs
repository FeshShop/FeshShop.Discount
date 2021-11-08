namespace FeshShop.Discounts.Models.Commands
{
    using FeshShop.Common.Mediator.Types;
    using Newtonsoft.Json;
    using System;

    public class CreateDiscountCommand : ICommand
    {
        [JsonConstructor]
        public CreateDiscountCommand(Guid id, Guid customerId, string code, short percentage)
        {
            this.Id = id;
            this.CustomerId = customerId;
            this.Code = code;
            this.Percentage = percentage;
        }

        public Guid Id { get; }

        public Guid CustomerId { get; }

        public string Code { get; }

        public short Percentage { get; }
    }
}
