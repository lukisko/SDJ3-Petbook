import model.City;
import model.Model;
import model.ModelManager;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

public class CityTest
{
  private Model model;
  private City city;

  @BeforeEach
  void setUp()
  {
    model = new ModelManager();
    city = new City();
    city.setName("TEST");
  }

  @Test
  void getCity(){
    model.addCity(city);
    City result = model.getCity(city.getName());

    assertEquals(city.getName(),result.getName());

    model.removeCity(result);
  }
  @Test
  void getAllCites(){
    List<City> cityList = model.getAllCities();

    assertTrue(1 < (long) cityList.size());
    assertEquals("BA", cityList.get(0).getName());
  }
  @Test
  void addCity(){
    model.addCity(city);
    City result = model.getCity(city.getName());

    assertNotNull(result);
    assertEquals(city.getName(),result.getName());

    model.removeCity(result);
  }
  @Test
  void removeCity(){
    model.addCity(city);
    model.removeCity(city);

    assertNull(model.getCity(city.getName()));
  }
}
