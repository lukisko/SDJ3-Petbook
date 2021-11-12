package DatabasePersistence;

import com.sun.security.ntlm.Client;
import model.Customer;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.Query;
import java.util.List;

public class Database<T>
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

  public void save(T object){
    entityManager.persist(object);
    entityManager.getTransaction().commit();
  }

  // mention in security the sql injection
  public List<T> load(String table){
    Query query = entityManager.createQuery("SELECT c FROM :table c");
    query.setParameter("table", table);
    List<T> result = query.getResultList();
    return result;

  }

}
