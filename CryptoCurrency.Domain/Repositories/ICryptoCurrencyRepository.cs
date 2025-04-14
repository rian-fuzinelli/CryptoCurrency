namespace CryptoCurrency.Domain.Repositories;

using Entities;

public interface ICryptoCurrencyRepository
{
    Task<IEnumerable<CryptoCurrency>> GetAllAsync();
    Task<CryptoCurrency?> GetByIdAsync(Guid id);
    Task AddAsync(CryptoCurrency crypto);
    Task UpdateAsync(CryptoCurrency crypto);
    Task DeleteAsync(Guid id);
}