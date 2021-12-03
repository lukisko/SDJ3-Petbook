package DatabasePersistence;

import model.City;
import model.Country;
import model.Pet;
import model.User;

import javax.persistence.Query;
import javax.persistence.criteria.CriteriaQuery;
import java.util.List;

public class CityDatabase implements CityPersistence {


  private Database database;


  public CityDatabase(){
    database = Database.getInstance();
  }


  @Override public City loadCity(String name) {
      database.beginSession();
      return database.getSession().get(City.class,name);
  }

  @Override public List<City> loadAll() {
      database.beginSession();
      CriteriaQuery<City> criteria = database.getBuilder().createQuery(City.class);
      criteria.from(City.class);
      List<City> data = database.getSession().createQuery(criteria).getResultList();
      return data;
  }

  @Override public void save(City city) {
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
