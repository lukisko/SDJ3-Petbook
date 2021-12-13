package DatabasePersistence;

import model.City;
import model.Country;
import model.Pet;
import model.User;

import javax.persistence.Query;
import javax.persistence.criteria.CriteriaQuery;
import java.util.List;

/**
 * used to load, save and remove cities from database
 */
public class CityDatabase implements CityPersistence {


  private Database database;


  public CityDatabase(){
    database = Database.getInstance();
  }


  @Override public City loadCity(String name) {
      if(name == null) throw new IllegalArgumentException();

      database.beginSession();
      City city = database.getSession().get(City.class,name);
      if(city != null)
      {
        city.clear();
      }
      return city;
  }

  @Override public List<City> loadAll() {
      database.beginSession();
      CriteriaQuery<City> criteria = database.getBuilder().createQuery(City.class);
      criteria.from(City.class);
      List<City> data = database.getSession().createQuery(criteria).getResultList();
      if(data != null){
        data.forEach(City::clear);
      }
      return data;
  }

  @Override public void save(City city) {
    if(city == null) throw new IllegalArgumentException();

    database.beginSession();
    database.getSession().persist(city);
    database.getSession().getTransaction().commit();
    database.getSession().close();
  }

  @Override public void delete(City city)
  {
    database.beginSession();
    database.getSession().delete(city);
    database.getSession().getTransaction().commit();
    database.getSession().close();
  }
}
