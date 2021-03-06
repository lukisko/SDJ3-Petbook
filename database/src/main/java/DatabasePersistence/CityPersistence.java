package DatabasePersistence;

import model.City;
import model.Country;
import model.Pet;
import model.User;

import java.util.List;

public interface CityPersistence {
  /**
   * loads specific city from database
   * @param name name of the city
   * @return city object
   */
  City loadCity(String name);
  /**
   * loads all cities from database
   * @return list of cities
   */
  List<City> loadAll();
  /**
   * saves city to database
   * @param city object to be saved
   * @throws IllegalArgumentException if city is null
   */
  void save(City city);
  /**
   * removes city from database
   * @param city object to be removed
   * @throws IllegalArgumentException if city is null or is not existing in database
   */
  void delete(City city);
}
