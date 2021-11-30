package DatabasePersistence;

import model.City;
import model.Pet;

import javax.persistence.Query;
import java.util.List;

public class CityDatabase implements CityPersistence {


  private Database database;


  public CityDatabase(){
    database = Database.getInstance();
  }


  @Override public City loadCity(String name) {
    try {
      if(!database.getSession().isOpen()){
        database.getSession().beginTransaction();
      }
      return database.getSession().get(City.class,name);
    }
    catch (Exception e) {
      System.out.println("CityDatabase_Exception: " + e.getMessage());
      return null;
    }
  }

  @Override public List<City> loadAll() {
    try {
      Query query = database.getSession().createQuery("SELECT c FROM city c");
      List<City> cityList = query.getResultList();
      return cityList;
    }
    catch (Exception e){
      System.out.println("CityDatabase_Exception: " + e.getMessage());
      return null;
    }
  }

  @Override public void save(City city) {
    if(!database.getSession().isOpen()){
      database.getSession().beginTransaction();
    };

    database.getSession().persist(city);
    database.getSession().getTransaction().commit();
    database.getSession().close();
  }
}
