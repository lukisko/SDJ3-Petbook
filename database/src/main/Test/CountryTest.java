import DatabasePersistence.CountryDatabase;
import DatabasePersistence.CountryPersistence;
import model.Country;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import java.util.List;

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
    Country result2 = countryPersistence.loadCountry(country2.getName());
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
  void getAllCountriesZero(){
    List<Country> result = countryPersistence.loadAll();
    result.removeIf(
        country -> !country.getName().equals(country1.getName()) && !country.getName()
            .equals(country2.getName()));
    assertEquals(0, result.size());
  }
  @Test
  void getAllCountriesOne(){
    countryPersistence.save(country1);
    List<Country> result = countryPersistence.loadAll();
    countryPersistence.delete(countryPersistence.loadCountry(country1.getName()));
    for (int x = 0; x < result.size(); x++)
    {
      if(!result.get(x).getName().equals(country1.getName()) && !result.get(x).getName().equals(country2.getName())){
        result.remove(x);
      }
    }
    assertNotNull(result);
    assertEquals(result.size(), 1);
  }
  @Test
  void getAllCountriesMany(){
    countryPersistence.save(country1);
    countryPersistence.save(country2);
    List<Country> result = countryPersistence.loadAll();
    countryPersistence.delete(countryPersistence.loadCountry(country1.getName()));
    countryPersistence.delete(countryPersistence.loadCountry(country2.getName()));
    result.removeIf(
        country -> !country.getName().equals(country1.getName()) && !country.getName()
            .equals(country2.getName()));
    assertNotNull(result);
    assertEquals(result.size(), 2);
  }
  @Test
  void getAllCountriesBoundary(){

  }
  @Test
  void getAllCountriesException(){

  }


  @Test
  void addCountryZero(){
    Country result = countryPersistence.loadCountry(country1.getName());

    assertNull(result);
  }
  @Test
  void addCountryOne(){
    assertNull(countryPersistence.loadCountry(country1.getName()));

    countryPersistence.save(country1);
    Country result = countryPersistence.loadCountry(country1.getName());
    countryPersistence.delete(result);

    assertNotNull(result);
    assertEquals("test1", result.getName());
  }
  @Test
  void addCountryMany(){
    assertNull(countryPersistence.loadCountry(country1.getName()));

    countryPersistence.save(country1);
    countryPersistence.save(country2);
    List<Country> result = countryPersistence.loadAll();
    countryPersistence.delete(countryPersistence.loadCountry(country1.getName()));
    countryPersistence.delete(countryPersistence.loadCountry(country2.getName()));
    result.removeIf(
        country -> !country.getName().equals(country1.getName()) && !country.getName()
            .equals(country2.getName()));
    assertNotNull(result);
    assertEquals(result.size(), 2);
  }
  @Test
  void addCountryBoundary(){

  }
  @Test
  void addCountryException(){
    assertThrows(IllegalArgumentException.class,() -> countryPersistence.save(null));
  }

}
