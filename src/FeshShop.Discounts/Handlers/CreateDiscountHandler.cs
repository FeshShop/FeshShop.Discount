namespace FeshShop.Discounts.Handlers
{
    using FeshShop.Common.Mediator.Types;
    using FeshShop.Discounts.Domain;
    using FeshShop.Discounts.Dto;
    using FeshShop.Discounts.Repositories;
    using System.Threading.Tasks;

    public class CreateDiscountHandler : ICommandHandler<CreateDiscountInputModel>
    {
        private readonly IDiscountRepository discountsRepository;

        public CreateDiscountHandler(IDiscountRepository discountsRepository)
            => this.discountsRepository = discountsRepository;

        public async Task HandleAsync(CreateDiscountInputModel model)
        {
            var discount = new Discount(model.Id, model.CustomerId, model.Code, model.Percentage);
            await this.discountsRepository.AddAsync(discount);
        }
    }
}
