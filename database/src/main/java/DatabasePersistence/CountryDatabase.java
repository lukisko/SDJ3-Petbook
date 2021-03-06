package DatabasePersistence;

import model.City;
import model.Country;

import javax.persistence.criteria.CriteriaQuery;
import java.util.List;

public class CountryDatabase implements CountryPersistence
{
  private Database database;

  public CountryDatabase(){
    database = Database.getInstance();
  }
  @Override public Country loadCountry(String name)
  {
      if(name == null) throw new IllegalArgumentException();

      database.beginSession();
      Country country = database.getSession().get(Country.class,name);
      if(country != null)
      {
        country.clear();
      }
      return country;
  }

  @Override public List<Country> loadAll()
  {
      database.beginSession();
      CriteriaQuery<Country> criteria = database.getBuilder().createQuery(Country.class);
      criteria.from(Country.class);
      List<Country> data = database.getSession().createQuery(criteria).getResultList();
    if(data != null)
    {
      data.forEach(n -> n.getCities().clear());
    }
      return data;
  }

  @Override public void save(Country country)
  {
    if(country == null) throw new IllegalArgumentException();

    database.beginSession();
    database.getSession().persist(country);
    database.getSession().getTransaction().commit();
    database.getSession().close();
  }

  @Override public void delete(Country country)
  {
    database.beginSession();
    database.getSession().delete(country);
    database.getSession().getTransaction().commit();
    database.getSession().close();
  }
}
