using Ardalis.GuardClauses;

namespace NimblePros.ValueObjects;

public class Address : ValueObject
{
  public String Street { get; private set; }
  public String City { get; private set; }
  public String State { get; private set; }
  public String Country { get; private set; }
  public String PostalCode { get; private set; }

  public Address() { }

  public Address(string street,
    string city,
    string state,
    string country,
    string postalCode)
  {
    Street = Guard.Against.NullOrEmpty(street, nameof(street));
    City = Guard.Against.NullOrEmpty(city, nameof(city));
    State = Guard.Against.NullOrEmpty(state, nameof(state));
    Country = Guard.Against.NullOrEmpty(country, nameof(country));
    PostalCode = Guard.Against.NullOrEmpty(postalCode, nameof(postalCode));
  }

  protected override IEnumerable<object> GetEqualityComponents()
  {
    // Using a yield return statement to return each element one at a time
    yield return Street;
    yield return City;
    yield return State;
    yield return Country;
    yield return PostalCode;
  }
}
