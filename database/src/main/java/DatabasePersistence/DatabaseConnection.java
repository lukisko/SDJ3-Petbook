package DatabasePersistence;

import model.Customer;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.EntityTransaction;
import javax.persistence.Persistence;
import java.util.List;

public class DatabaseConnection<T>
{
  private EntityManagerFactory entityManagerFactory;
  private EntityManager entityManager;

  private static DatabaseConnection instance;

  private DatabaseConnection(){
    entityManagerFactory = Persistence.createEntityManagerFactory("petBookDBS");
    entityManager= entityManagerFactory.createEntityManager();
    entityManager.getTransaction().begin();
  }

  public synchronized static DatabaseConnection getInstance() {
    if (instance == null) {
      instance = new DatabaseConnection();
    }
    return instance;
  }

  public void save(T object){
    entityManager.persist(object);
    entityManager.getTransaction().commit();
  }
  public List<T> load(String object){
    List<T> c = entityManager.createQuery("SELECT c FROM " + object + " c").getResultList();
    return c;
  }

}
