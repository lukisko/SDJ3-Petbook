package DatabasePersistence;


import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;

public class Database
{
  private EntityManagerFactory entityManagerFactory;
  private EntityManager entityManager;

  private static Database instance;

  private Database(){
    entityManagerFactory = Persistence.createEntityManagerFactory("petBookDBS");
    entityManager= entityManagerFactory.createEntityManager();
    entityManager.getTransaction().begin();
  }

  public synchronized static Database getInstance() {
    if (instance == null) {
      instance = new Database();
    }
    return instance;
  }

  public EntityManager getEntityManager(){
    return entityManager;
  }

}
