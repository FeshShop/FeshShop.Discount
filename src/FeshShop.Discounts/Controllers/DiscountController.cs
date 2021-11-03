namespace FeshShop.Discounts.Controllers
{
    using FeshShop.Common.Mediator.Contracts;
    using FeshShop.Common.Mvc;
    using FeshShop.Discounts.Dto;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class DiscountController : ApiController
    {
        public DiscountController(IMediator mediator) 
            : base(mediator)
        {
        }

        [HttpPost]
        [Route(nameof(CreateDiscount))]
        public async Task<IActionResult> CreateDiscount([FromBody] CreateDiscountInputModel model)
            => await this.SendAsync(model.BindId(x => x.Id));
    }
}
