package DatabasePersistence;

import model.Customer;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import java.util.List;

public class UserDatabase implements UserPersistence
{
  private static UserDatabase instance;
  private DatabaseConnection customers;


  private UserDatabase(){
    customers = DatabaseConnection.getInstance();
  }

  public synchronized static UserDatabase getInstance() {
    if (instance == null) {
      instance = new UserDatabase();
    }
    return instance;
  }

  @Override public Customer load(String email)
  {
    List<Customer> customerList= customers.load("customer");
    for (Customer c: customerList) {
      if(c.getEmail().equals(email)){
        return c;
      }
    }
    return null;
  }

  @Override public void save(Customer customer)
  {
    customers.save(customer);
  }
}
