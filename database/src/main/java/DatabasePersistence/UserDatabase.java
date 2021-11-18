package DatabasePersistence;

import model.User;

import javax.persistence.Query;
import java.util.List;

public class UserDatabase implements UserPersistence
{
  private static UserDatabase instance;
  private Database database;


  private UserDatabase(){
    database = Database.getInstance();
  }

  public synchronized static UserDatabase getInstance() {
    if (instance == null) {
      instance = new UserDatabase();
    }
    return instance;
  }

  @Override public User loadUser(String email)
  {
    Query query = database.getEntityManager().createQuery("SELECT c FROM user c");
    List<User> customerList = query.getResultList();

    for (User c: customerList) {
      if(c.getEmail().equals(email)){
        return c;
      }
    }
    return null;
  }

  @Override public List<User> loadAll()
  {
    Query query = database.getEntityManager().createQuery("SELECT c FROM user c");
    List<User> customerList = query.getResultList();
    return customerList;
  }

  @Override public void save(User customer)
  {
    database.getEntityManager().persist(customer);
    database.getEntityManager().getTransaction().commit();
  }
}
