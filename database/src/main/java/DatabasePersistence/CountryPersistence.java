package DatabasePersistence;

import model.City;
import model.Country;

import java.util.List;

public interface CountryPersistence
{
  Country loadCountry(String name);
  List<Country> loadAll();
  void save(Country country);
  void delete(Country country);
}
