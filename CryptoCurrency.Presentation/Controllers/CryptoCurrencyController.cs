namespace CryptoCurrency.Presentation.Controllers;

using Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/cryptocurrencies")]
public class CryptoCurrencyController : ControllerBase
{
    private readonly IMediator _mediator;
    public CryptoCurrencyController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _mediator.Send(new CryptoCurrencyGetAllQuery());
        return Ok(result);
    }
}