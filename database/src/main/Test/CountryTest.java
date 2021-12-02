import model.Country;
import model.Model;
import model.ModelManager;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

public class CountryTest
{
  private Model model;
  private Country country1;
  private Country country2;
  private Country country3;

  @BeforeEach
  void setUp()
  {
    model = new ModelManager();
    country1 = new Country("test");
    country2 = new Country("test1");
    country3 = new Country("test2");

    model.addCountry(country1);
  }
  @AfterEach
  void setDown(){
    if(model.getCountry(country1.getName()) != null){
      model.removeCountry(model.getCountry(country1.getName()));
    }
  }

  @Test
  void getCountry(){

    Country result = model.getCountry(country1.getName());

    assertNotNull(result);
    assertEquals("test",result.getName());
  }
  @Test
  void getAllCites(){
    model.addCountry(country2);
    model.addCountry(country3);
    List<Country> countries = model.getAllCountries();
    model.removeCountry(model.getCountry(country2.getName()));
    model.removeCountry(model.getCountry(country3.getName()));

    assertTrue(1 < (long) countries.size());
    assertEquals("test1", countries.get(1).getName());
  }
  @Test
  void addCity(){

    Country result = model.getCountry(country1.getName());

    assertNotNull(result);
    assertEquals("test",result.getName());

  }
  @Test
  void removeCity(){
    model.removeCountry(country1);

    assertNull(model.getCity("test"));
  }
}
