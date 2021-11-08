namespace FeshShop.Discounts.Handlers
{
    using FeshShop.Common.Mediator.Types;
    using FeshShop.Discounts.Domain;
    using FeshShop.Discounts.Models.Commands;
    using FeshShop.Discounts.Repositories;
    using System.Threading.Tasks;

    public class CreateDiscountHandler : ICommandHandler<CreateDiscountCommand>
    {
        private readonly IDiscountRepository discountsRepository;

        public CreateDiscountHandler(IDiscountRepository discountsRepository)
            => this.discountsRepository = discountsRepository;

        public async Task HandleAsync(CreateDiscountCommand model)
        {
            var discount = new Discount(model.Id, model.CustomerId, model.Code, model.Percentage);
            await this.discountsRepository.AddAsync(discount);
        }
    }
}
