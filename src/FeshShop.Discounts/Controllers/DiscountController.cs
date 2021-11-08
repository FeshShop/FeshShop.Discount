namespace FeshShop.Discounts.Controllers
{
    using FeshShop.Common.Mediator.Contracts;
    using FeshShop.Common.Mvc;
    using FeshShop.Discounts.Models.Commands;
    using FeshShop.Discounts.Models.Dto;
    using FeshShop.Discounts.Models.Queries;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class DiscountController : ApiController
    {
        public DiscountController(IMediator mediator) 
            : base(mediator)
        {
        }

        [HttpGet]
        [Route(nameof(Get) + PathSeparator + Id)]
        public async Task<ActionResult<IEnumerable<GetDiscountDto>>> Get([FromRoute] GetDiscountQuery model)
            => this.Single(await this.QueryAsync(model));


        [HttpPost]
        [Route(nameof(CreateDiscount))]
        public async Task<IActionResult> CreateDiscount([FromBody] CreateDiscountCommand model)
            => await this.SendAsync(model.BindId(x => x.Id));
    }
}
