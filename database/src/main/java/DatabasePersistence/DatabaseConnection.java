package DatabasePersistence;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.EntityTransaction;
import javax.persistence.Persistence;

public class DatabaseConnection<T>
{
  private EntityManagerFactory entityManagerFactory;
  private EntityManager entityManager;

  private static DatabaseConnection instance;

  private DatabaseConnection(){
    entityManagerFactory = Persistence.createEntityManagerFactory("petBookDBS");
    entityManager= entityManagerFactory.createEntityManager();
  }

  public synchronized static DatabaseConnection getInstance() {
    if (instance == null) {
      instance = new DatabaseConnection();
    }
    return instance;
  }

  public EntityManager getEntityManager(){
    return entityManager ;
  }
  public EntityManagerFactory getEntityManagerFactory(){
    return entityManagerFactory ;
  }

}
