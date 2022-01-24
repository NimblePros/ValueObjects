using FluentAssertions.Execution;
using Xunit;

namespace NimblePros.ValueObjects.UnitTests.AddressTests;

public class AddressConstructor
{
  private string _validCity = "city";
  private string _validState = "state";
  private string _validCountry = "country";
  private string _validStreet = "street";
  private string _validPostalCode = "postalCode";

  [Fact]
  public void SetsProperties()
  {
    var address = new Address(_validStreet, _validCity, _validState, _validCountry, _validPostalCode);

    using(new AssertionScope())
    {
      Assert.Equal(_validStreet, address.Street);
      Assert.Equal(_validCity, address.City);
      Assert.Equal(_validState, address.State);
      Assert.Equal(_validCountry, address.Country);
      Assert.Equal(_validPostalCode, address.PostalCode);
    }
  }
}
