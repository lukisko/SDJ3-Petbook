package DatabasePersistence;

import model.City;
import model.Country;
import model.Pet;
import model.User;
import org.hibernate.Hibernate;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.criteria.CriteriaBuilder;

public class Database
{

  private Configuration configuration;
  private SessionFactory factory;
  private Session session;
  private CriteriaBuilder builder;

  private static Database instance;

  private Database()
  {
    configuration = new Configuration().addAnnotatedClass(User.class)
        .addAnnotatedClass(Pet.class).addAnnotatedClass(City.class).addAnnotatedClass(
            Country.class).configure();
    factory = configuration.buildSessionFactory();
    session = factory.getCurrentSession();
    session.beginTransaction();
    builder = session.getCriteriaBuilder();
  }

  public synchronized static Database getInstance()
  {
    if (instance == null)
    {
      instance = new Database();
    }
    return instance;
  }

  public void beginSession()
  {
    if(!session.getTransaction().isActive())
    {
      session = session.getSessionFactory().openSession();
      session.beginTransaction();
    }
  }

  public Session getSession()
  {
    return session;
  }

  public CriteriaBuilder getBuilder()
  {
    return builder;
  }
}
