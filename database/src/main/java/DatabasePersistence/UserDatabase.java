package DatabasePersistence;

import model.Customer;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import java.util.List;

public class UserDatabase implements UserPersistence
{
  private static UserDatabase instance;
  private EntityManager entityManager;
  private EntityManagerFactory entityManagerFactory;

  private UserDatabase(){
    entityManager = DatabaseConnection.getInstance().getEntityManager();
    entityManagerFactory = DatabaseConnection.getInstance().getEntityManagerFactory();
  }

  public synchronized static UserDatabase getInstance() {
    if (instance == null) {
      instance = new UserDatabase();
    }
    return instance;
  }

  @Override public Customer load(String email)
  {
    Customer result = new Customer();
    List<Customer> c = entityManager.createQuery("SELECT c FROM customer c").getResultList();
    for (Customer customer: c)
    {
      if(customer.getEmail().equals(email)){
        result = customer;
      }
    }
    //entityManager.close();
    return result;

  }

  @Override public void save(Customer customer)
  {
    entityManager.getTransaction().begin();
    entityManager.persist(customer);
    entityManager.getTransaction().commit();
    //entityManager.close();
  }
}
