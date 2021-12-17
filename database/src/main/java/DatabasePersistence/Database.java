package DatabasePersistence;

import model.*;
import org.hibernate.Hibernate;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;

import org.hibernate.Hibernate;
import org.hibernate.Session;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.criteria.CriteriaBuilder;

/**
 * Database class used for connecting to database
 */
public class Database {
  private Configuration configuration;
  private SessionFactory factory;
  private Session session;
  private CriteriaBuilder builder;
  private static Database instance;
  /**
   * Constructor which initialize all instant variables
   */
  private Database() {
    configuration = new Configuration().addAnnotatedClass(User.class)
        .addAnnotatedClass(Pet.class).addAnnotatedClass(City.class).addAnnotatedClass(
            Country.class).addAnnotatedClass(Status.class).addAnnotatedClass(Message.class).configure();
    factory = configuration.buildSessionFactory();
    session = factory.getCurrentSession();
    session.beginTransaction();
    builder = session.getCriteriaBuilder();
  }
  /**
   * method for getting instance of database class
   * @return instance of database class
   */
  public synchronized static Database getInstance() {
    if (instance == null) {
      instance = new Database();
    }
    return instance;
  }
  /**
   * getting session object
   * @return session object
   */
  public Session getSession()
  {
    return session;
  }
  /**
   * method for starting connection with database
   */
  public synchronized void beginSession() {
    if(!session.getTransaction().isActive()) {
      session = session.getSessionFactory().openSession();
      session.beginTransaction();
    }
  }
  /**
   * getting criteriaBuilder which can be used for creating of queries
   * @return builder
   */
  public CriteriaBuilder getBuilder()
  {
    return builder;
  }
}
