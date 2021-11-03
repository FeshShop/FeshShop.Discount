namespace FeshShop.Discounts.Repositories
{
    using FeshShop.Discounts.Domain;
    using System.Threading.Tasks;

    public interface IDiscountRepository
    {
        Task AddAsync(Discount discount);
    }
}
