package DatabasePersistence;


import model.City;
import model.Pet;
import model.User;
import org.hibernate.Hibernate;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;


public class Database
{

  private Configuration configuration;
  private SessionFactory factory;
  private Session session;

  private static Database instance;


  private Database(){
    configuration = new Configuration().addAnnotatedClass(User.class).addAnnotatedClass(
        Pet.class).addAnnotatedClass(City.class).configure();
    factory = configuration.buildSessionFactory();
    session = factory.getCurrentSession();

  }

  public synchronized static Database getInstance() {
    if (instance == null) {
      instance = new Database();
    }
    return instance;
  }

public void beginSession(){
  session = session.getSessionFactory().openSession();
  session.beginTransaction();
}
  public Session getSession(){
    return session;
  }

}
