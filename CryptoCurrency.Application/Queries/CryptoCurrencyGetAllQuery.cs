namespace CryptoCurrency.Application.Queries;

using Domain.Entities;
using MediatR;

public record CryptoCurrencyGetAllQuery : IRequest<IEnumerable<CryptoCurrency>>;
