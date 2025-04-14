namespace CryptoCurrency.Application.Handlers;

using Domain.Entities;
using Domain.Repositories;
using MediatR;
using Queries;

public class CryptoCurrencyGetAllHandler : IRequestHandler<CryptoCurrencyGetAllQuery, IEnumerable<CryptoCurrency>>
{
    private readonly ICryptoCurrencyRepository _cryptoCurrencyRepository;
    
    public CryptoCurrencyGetAllHandler(ICryptoCurrencyRepository cryptoCurrencyRepository)
    {
        _cryptoCurrencyRepository = cryptoCurrencyRepository;
    } 
    
    public async Task<IEnumerable<CryptoCurrency>> Handle(CryptoCurrencyGetAllQuery request, CancellationToken cancellationToken)
    {
        return await _cryptoCurrencyRepository.GetAllAsync();
    }
}
