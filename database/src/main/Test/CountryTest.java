import DatabasePersistence.CountryDatabase;
import DatabasePersistence.CountryPersistence;
import model.Country;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

public class CountryTest
{
  private CountryPersistence countryPersistence;
  private Country country1;
  private Country country2;

  @BeforeEach
  void setUp()
  {
    countryPersistence = new CountryDatabase();
    country1 = new Country("test1");
    country2 = new Country("test2");
  }


  @Test
  void getCountryZero(){
    Country result = countryPersistence.loadCountry(country1.getName());

    assertNull(result);
  }
  @Test
  void getCountryOne(){
    countryPersistence.save(country1);
    Country result = countryPersistence.loadCountry(country1.getName());
    countryPersistence.delete(result);

    assertNotNull(result);
    assertEquals("test1", result.getName());
  }
  @Test
  void getCountryMany(){
    countryPersistence.save(country1);
    countryPersistence.save(country2);
    Country result1 = countryPersistence.loadCountry(country1.getName());
    Country result2 = countryPersistence.loadCountry(country1.getName());
    countryPersistence.delete(result1);
    countryPersistence.delete(result2);

    assertNotNull(result1);
    assertEquals("test1", result1.getName());
  }
  @Test
  void getCountryBoundary(){

  }
  @Test
  void getCountryException(){
    assertThrows(IllegalArgumentException.class,() -> countryPersistence.loadCountry(null));
  }


  @Test
  void getAllCites(){

  }
  @Test
  void addCity(){


  }
  @Test
  void removeCity(){

  }
}
