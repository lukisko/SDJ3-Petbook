import DatabasePersistence.CityDatabase;
import DatabasePersistence.CityPersistence;
import DatabasePersistence.CountryDatabase;
import DatabasePersistence.CountryPersistence;
import model.City;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

public class CityTest
{
  private CityPersistence cityPersistence;
  private CountryPersistence countryPersistence;
  private City city1;
  private City city2;

  @BeforeEach
  void setUp()
  {
    cityPersistence = new CityDatabase();
    countryPersistence = new CountryDatabase();
    city1 = new City("test1");
    city1.setCountry(countryPersistence.loadCountry("asd"));
    city2 = new City("test2");
    city2.setCountry(countryPersistence.loadCountry("asd"));
  }

  @Test
  void getCityZero(){
    City result = cityPersistence.loadCity(city1.getName());

    assertNull(result);
  }
  @Test
  void getCityOne(){
    cityPersistence.save(city1);
    City result = cityPersistence.loadCity(city1.getName());
    cityPersistence.delete(result);

    assertNotNull(result);
    assertEquals(city1.getName(),result.getName());
  }
  @Test
  void getCityMany(){
    cityPersistence.save(city1);
    cityPersistence.save(city2);
    City result1 = cityPersistence.loadCity(city1.getName());
    City result2 = cityPersistence.loadCity(city2.getName());
    cityPersistence.delete(result1);
    cityPersistence.delete(result2);

    assertNotNull(result1);
    assertEquals(city1.getName(),result1.getName());
    assertEquals(city2.getName(),result2.getName());
  }
  @Test
  void getCityBoundary(){

  }
  @Test
  void getCityException(){
    assertThrows(IllegalArgumentException.class,() -> cityPersistence.loadCity(null));
  }


  @Test
  void getAllCitesZero(){
    List<City> result = cityPersistence.loadAll();
    result.removeIf(x -> !x.getName().equals(city1.getName()) && !x.getName()
        .equals(city2.getName()));
    assertEquals(0, result.size());
  }
  @Test
  void getAllCitesOne(){
    cityPersistence.save(city1);
    List<City> result = cityPersistence.loadAll();
    cityPersistence.delete(cityPersistence.loadCity(city1.getName()));
    result.removeIf(x -> !x.getName().equals(city1.getName()) && !x.getName()
        .equals(city2.getName()));
    assertEquals(1, result.size());
  }
  @Test
  void getAllCitesMany(){
    cityPersistence.save(city1);
    cityPersistence.save(city2);
    List<City> result = cityPersistence.loadAll();
    cityPersistence.delete(cityPersistence.loadCity(city1.getName()));
    cityPersistence.delete(cityPersistence.loadCity(city2.getName()));
    result.removeIf(x -> !x.getName().equals(city1.getName()) && !x.getName()
        .equals(city2.getName()));
    assertEquals(2, result.size());
  }
  @Test
  void getAllCitesBoundary(){

  }
  @Test
  void getAllCitesException(){

  }



  @Test
  void addCityZero(){
    City result = cityPersistence.loadCity(city1.getName());

    assertNull(result);
  }
  @Test
  void addCityOne(){
    cityPersistence.save(city1);
    City result = cityPersistence.loadCity(city1.getName());
    cityPersistence.delete(result);

    assertNotNull(result);
    assertEquals(city1.getName(),result.getName());
  }
  @Test
  void addCityMany(){
    cityPersistence.save(city1);
    cityPersistence.save(city2);
    City result1 = cityPersistence.loadCity(city1.getName());
    City result2 = cityPersistence.loadCity(city2.getName());
    cityPersistence.delete(result1);
    cityPersistence.delete(result2);

    assertNotNull(result1);
    assertEquals(city1.getName(),result1.getName());
    assertEquals(city2.getName(),result2.getName());
  }
  @Test
  void addCityBoundary(){

  }
  @Test
  void addCityException(){
    assertThrows(IllegalArgumentException.class,() -> cityPersistence.save(null));
  }

}
