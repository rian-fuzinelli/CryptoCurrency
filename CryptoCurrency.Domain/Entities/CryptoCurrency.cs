namespace CryptoCurrency.Domain.Entities;

public class CryptoCurrency
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Symbol { get; set; }
    public decimal CurrentPrice { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}