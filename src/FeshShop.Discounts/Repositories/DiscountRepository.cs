namespace FeshShop.Discounts.Repositories
{
    using FeshShop.Common.Mongo.Contracts;
    using FeshShop.Discounts.Domain;
    using System.Threading.Tasks;

    public class DiscountRepository : IDiscountRepository
    {
        private readonly IMongoRepository<Discount> mongoRepository;

        public DiscountRepository(IMongoRepository<Discount> mongoRepository)
            => this.mongoRepository = mongoRepository;

        public async Task AddAsync(Discount discount) => await this.mongoRepository.AddAsync(discount);
    }
}
