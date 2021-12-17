package DatabasePersistence;

import model.City;
import model.Country;

import java.util.List;

public interface CountryPersistence
{
  /**
   * loads specific country from database
   * @param name name of the country
   * @return country object
   * @throws IllegalArgumentException if name of country is null
   */
  Country loadCountry(String name);
  /**
   * loads all of countries in database
   * @return list of countries
   */
  List<Country> loadAll();
  /**
   * saves country into database
   * @param country country object to be saved
   * @throws IllegalArgumentException if country is null
   */
  void save(Country country);
  /**
   * deletes country from database
   * @param country country object to be deleted
   * @throws IllegalArgumentException if country is null or is not existing inside of database
   */
  void delete(Country country);
}
