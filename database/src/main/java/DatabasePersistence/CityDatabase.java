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
      Query query = database.getEntityManager().createQuery("SELECT c FROM city c WHERE name = :city_name");
      query.setParameter("city_name",name);
      City city = (City) query.getSingleResult();
      return city;
    }
    catch (Exception e) {
      System.out.println("CityDatabase_Exception: " + e.getMessage());
      return null;
    }
  }

  @Override public List<City> loadAll() {
    try {
      Query query = database.getEntityManager().createQuery("SELECT c FROM city c");
      List<City> cityList = query.getResultList();
      return cityList;
    }
    catch (Exception e){
      System.out.println("CityDatabase_Exception: " + e.getMessage());
      return null;
    }
  }

  @Override public void save(City city) {
    if(!database.getEntityManager().getTransaction().isActive()) {
      database.getEntityManager().getTransaction().begin();
    }
    database.getEntityManager().persist(city);
    database.getEntityManager().getTransaction().commit();
  }
}
