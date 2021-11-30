package DatabasePersistence;


import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;

/**
 * Class Database connects to database repository
 * threw creating EntityManagerFactory which is using
 * persistence xml file to get database information
 */
public class Database
{
  private EntityManagerFactory entityManagerFactory;
  private EntityManager entityManager;

  private static Database instance;

  /**
   * Constructor initialising all instant variables
   */
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

  /**
   * get entityManager of database
   * @return entityManager, used for communicating with database
   */
  public EntityManager getEntityManager(){
    return entityManager;
  }

}
