namespace FeshShop.Discounts.Handlers
{
    using FeshShop.Common.Mediator.Types;
    using FeshShop.Common.Mongo.Contracts;
    using FeshShop.Discounts.Domain;
    using FeshShop.Discounts.Models.Dto;
    using FeshShop.Discounts.Models.Queries;
    using Mapster;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class FindDiscountsHandler : IQueryHandler<GetDiscountQuery, IEnumerable<GetDiscountDto>>
    {
        private readonly IMongoRepository<Discount> mongoRepository;

        public FindDiscountsHandler(IMongoRepository<Discount> mongoRepository) => this.mongoRepository = mongoRepository;

        public async Task<IEnumerable<GetDiscountDto>> HandleAsync(GetDiscountQuery query)
        {
            var discounts = await this.mongoRepository.FindAsync(x => x.CustomerId == query.Id);
            var config = new TypeAdapterConfig();
            config
                .NewConfig<Discount, GetDiscountDto>()            
                .Map(dest => dest.Availiable, src => !src.UsedAt.HasValue);

            return discounts?.Adapt<IEnumerable<GetDiscountDto>>(config);
        }
    }
}
