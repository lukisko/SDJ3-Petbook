package DatabasePersistence;

import model.City;
import model.Pet;
import model.User;

import java.util.List;

public interface CityPersistence {
  City loadCity(String name);
  List<City> loadAll();
  void save(City city);
}
