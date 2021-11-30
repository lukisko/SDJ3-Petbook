package DatabasePersistence;

import model.City;
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
    try {
      database.beginSession();
      return database.getSession().get(City.class,name);
    }
    catch (Exception e) {
      System.out.println("CityDatabase_Exception: " + e.getMessage());
      return null;
    }
  }

  @Override public List<City> loadAll() {
    try {
      CriteriaQuery<City> criteria = database.getBuilder().createQuery(City.class);
      criteria.from(City.class);
      List<City> data = database.getSession().createQuery(criteria).getResultList();
      return data;
    }
    catch (Exception e){
      System.out.println("CityDatabase_Exception: " + e.getMessage());
      return null;
    }
  }

  @Override public void save(City city) {
    database.beginSession();

    database.getSession().persist(city);
    database.getSession().getTransaction().commit();
    database.getSession().close();
  }
}
