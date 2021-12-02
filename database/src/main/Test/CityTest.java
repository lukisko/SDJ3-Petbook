import model.City;
import model.Country;
import model.Model;
import model.ModelManager;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

public class CityTest
{
  private Model model;
  private City city1;
  private City city2;
  private City city3;
  private Country country;

  @BeforeEach
  void setUp()
  {
    model = new ModelManager();
    country = new Country("test");
    city1 = new City("test");
    city2 = new City("test1");
    city3 = new City("test2");
    model.addCountry(country);
    model.addCity(country.getName(), city1);
  }
  @AfterEach
  void setDown(){
    if(model.getCity(city1.getName()) != null){
      model.removeCity(model.getCity(city1.getName()));
    }
    model.removeCountry(model.getCountry(country.getName()));
  }

  @Test
  void getCity(){

    City result = model.getCity(city1.getName());

    assertNotNull(result);
    assertEquals("test",result.getName());
  }
  @Test
  void getAllCites(){
    model.addCity(country.getName(), city2);
    model.addCity(country.getName(), city3);
    List<City> cityList = model.getAllCities();
    model.removeCity(model.getCity(city2.getName()));
    model.removeCity(model.getCity(city3.getName()));

    assertTrue(1 < (long) cityList.size());
    assertEquals("test1", cityList.get(1).getName());
  }
  @Test
  void addCity(){

    City result = model.getCity(city1.getName());

    assertNotNull(result);
    assertEquals("test",result.getName());

    model.removeCity(result);
  }
  @Test
  void removeCity(){
    model.removeCity(city1);

    assertNull(model.getCity("test"));
  }
}
